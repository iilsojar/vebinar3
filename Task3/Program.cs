//напишите программу, которая на вход будет принимать два числа и выводить, является ли второе число кратно первому, 
//если число 2 не кратно числу 1, то программа выводит остаток от деления
//34, 5 -не кратно, остаток 4
//16, 4 - кратно

Console.Clear();
Console.WriteLine("введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
int C = numberB%numberA;
if (C == 0)
    Console.WriteLine ($"число {numberB} кратно {numberA}");
else
{
    Console.WriteLine ($"число {numberB} некратно {numberA} остаток {C}");
}


