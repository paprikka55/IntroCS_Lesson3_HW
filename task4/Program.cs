// Задача 4**(не обязательно): Дано натуральное
// число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд
// числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива
// должен быть равен количеству цифр.
void PrintInputError()
{
  Console.WriteLine("Ошибка ввода данных!");
}

int InputNum ()
{
  int num = 0;
  while(true)
  {
    Console.Write("Введите натуральное число от 1 до 100000: ");
    string inputStr = Console.ReadLine();
    if (CheckinputData(inputStr))
    {
      num = Convert.ToInt32(inputStr);
      break;
    }
  }
  return num;
}

bool CheckinputData(string inputStr)
{
  int num = 0;
  try
  {
    num = Convert.ToInt32(inputStr);
  }
  catch
  {
    PrintInputError();
    return false;
  }
  if (num >= 1 && num <= 100000 )
    return true;
  else
    {
      PrintInputError();
      return false;
    }
}

 int[] CreateArrayFromNum(int num)
 {
  int size = GetSizeOfNumber(num);
  int[] arr = new int[size];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = (num / Convert.ToInt32(Math.Pow(10, size - i - 1))) % 10;
  }
  return arr;
 }

int GetSizeOfNumber(int num)
{
  int size = 0;
  while(num > 0)
  {
    size++;
    num /= 10;
  }
  return size;
}

void PrintArray(int[] arr)
{
  Console.Write("Массив: ");
  foreach(int el in arr)
  {
    Console.Write($"{el} ");
  }
  Console.WriteLine();
}

int number = InputNum();
int[] arr = CreateArrayFromNum(number);
PrintArray(arr);


