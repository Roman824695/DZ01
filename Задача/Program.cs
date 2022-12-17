Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] input = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
      input[i] = Console.ReadLine();
}

string[] output = new string[size];
int p = 0;

for (int j = 0; j < size; j++)
{
    if (input[j].Length <= 3)
    {
        output[p] = input[j];
        p++;
    }
}

Console.WriteLine();
PrintArray(output);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}