//Задача:Написать программу, которая из имеющегося массива строк формирует
//новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите число элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];

Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < n; i++)
{
array[i] = Console.ReadLine();
}

void PrintArray(string[] array)
{
for(int i = 0; i < array.Length; i++)
{
System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();
}

string[] newArray = new string[0];

string[] FilterArray(string[] array)
{
List<string> newArray = new List<string>();
for (int i = 0; i < array.Length; i++)
{
if (array[i].Length <= 3)
{
newArray.Add(array[i]);
}
}
return newArray.ToArray();
}
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Массив с элементами длиной меньше или равной 3:");
PrintArray(FilterArray(array));
