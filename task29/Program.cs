// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

Console.Clear();

void tet (int num)
{
    int[] dig = new int[num];
    Random number = new Random(num);

    for (int i = 0; i < dig.Length; i++)
    {
        dig[i] = number.Next(num);
        Console.Write(dig[i] + " ");
    }
    
}

Console.WriteLine("Сколько вывести элементов? ");
int kek = int.Parse(Console.ReadLine()!);
tet(kek);