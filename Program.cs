/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Элементы задаются рандомно. Итоговый массив должен содержать в себе суммы цифр числа.
Т.е. необходимо подсчитывать суммы цифр чисел и записывать их в новый массив.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
63, 12, 33, 36 -> [9, 3, 6, 9] */

int[] Array(int args)
{
int[] octopus = new int[args];
for (int i = 0; i < args; i++)
{
octopus[i] = new Random().Next(10, 99);
}
return octopus;
}

int[] sum(int[] args)
{
int[] arr = new int[args.Length];
for (int i = 0; i < args.Length; i++)
{
    string a = args[i].ToString();
    int sum = 0;
    for (int j = 0; j < a.Length; j++)
    {
        sum = sum + (int)Char.GetNumericValue(a[j]);
    }
    arr[i] = sum;
}
return arr;
}

void Print(int[] a, int[] b)
{
    Console.WriteLine();
    Console.WriteLine("Получился начальный массив: " + String.Join(", ", a) + ".");
    Console.WriteLine();
    Console.WriteLine("Итоговый массив: " + String.Join(", ", b) + ".");
    Console.WriteLine();
}

int[] orig = Array(8);
int[] second = sum(orig);
Print(orig, second);