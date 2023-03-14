string[] FillStringArray(int n)
{
    string[] array = new string[n];
    Console.WriteLine("Начните ввод значений: ");
    for (int i = 0; i < array.Length; i++)
    {
        string? str = Console.ReadLine();
        array[i] = str;
    }
    return array;
}

Console.Clear();

Console.WriteLine("Условие:\nИз имеющегося массива строк необходимо сформировать массив, длина строк которого меньше либо равна 3м символам.");

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] startArray = FillStringArray(n);

Console.WriteLine($"Начальный массив: [{string.Join(", ", startArray)}]");

int count = 0;
foreach (string element in startArray)
{
    if (element.Length <= 3)
        count++;
}

string[] newArray = new string[count];

int j = 0;
for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= 3)
    {
        newArray[j] = startArray[i];
        j++;
    }
}

Console.WriteLine($"Конечный массив: [{string.Join(", ", newArray)}]");