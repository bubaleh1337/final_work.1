/* Написать программу, которая из имеющегося
массива строк формирует массив из строк, длина
которых меньше либо равно 3 символа. Первоначальный
массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись 
исключительно массивами.

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

Console.WriteLine();
string[] originalArray = GetArray();
string[] finalArray = new string [originalArray.Length];
Console.WriteLine();
PrintArray(originalArray);
Console.Write(" -> ");
FindElements(originalArray, finalArray);
PrintArray(finalArray);


string Prompt()
{
  Console.Write($"Enter string element: ");
  string str = Console.ReadLine()!.ToString();
  return str;
}

string[] GetArray()
{
  int size = new Random().Next(3, 6);
  string[] array = new string[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = Prompt();
  }
  return array;
}

void PrintArray(string[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
}

/* string[] FindElement(string[] array1)
{
  int count = 0;
  string[] array2 = new string[array1.Length];
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <= 3)
    {
      array2[count] = array1[i];
      count++;
    }
  }
  return array2;
} */

string[] FindElements(string[] array1, string[] array2)
{
  int count = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <= 3)
    {
      array2[count] = array1[i];
      count++;
    }
  }
  return array2;
}