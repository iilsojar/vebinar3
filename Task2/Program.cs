//напишите программу, которая выводит случайное трехзначное число и удаляет вторую  цифру этого числа

Console.Clear();
Random rnd = new Random();
int x = rnd.Next(100, 1000);
Console.WriteLine(x);

int a = x % 10; //получим остаток от деления на 10 - остаток и есть третья цифра в трехзначном числе
int b = x / 100; //получим первую цифру трехзначного числа
int ab = b * 10 + a;
Console.WriteLine(ab);

