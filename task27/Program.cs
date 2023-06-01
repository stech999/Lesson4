// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

void number(int n)
{
    string m = n.ToString();
    int sum = 0;
    for (int i = 0; i < m.Length; i++)
    {
        int digit = int.Parse(m[i].ToString());
        sum += digit;
    }
    Console.WriteLine(sum);
}

Console.WriteLine("Введите число: ");
int mom = int.Parse(Console.ReadLine()!);

number(mom);