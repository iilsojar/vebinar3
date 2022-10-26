//напишите программу, которая выводит случайное число из отрезка (10, 99) и показывает наибольшую цифру числа
//78 -> 8
//12 -> 2
//85 -> 8

Console.Clear();
Random rnd = new Random();
int x = rnd.Next(10, 100);
Console.WriteLine(x);
int a = x / 10;
int b = x % 10;

int max = a;
if(b > a)
{
    max = b;
}
else
{
    max = a;
}
Console.WriteLine($"наибольшее число {max}");





















