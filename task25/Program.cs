// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

Console.Clear();

void sq (int ehhh)
{
    Console.Write("в какую степень будем возводить: ");
    int ooo = int.Parse(Console.ReadLine()!);

    int uuu = 1;
    for (int i = 0; i < ooo; i++)
    {
        uuu *= ehhh;
    }
    Console.Write($"Ваше число {ehhh} в степни {ooo} будет {uuu}");
}

Console.Write("Напишите число которе будем возводить в степень: ");
int num = int.Parse(Console.ReadLine()!);
sq(num);