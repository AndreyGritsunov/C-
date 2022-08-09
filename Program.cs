// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int number_one = Convert.ToInt32(Console.Read());
Console.WriteLine("Введите число2:");
int number_two = Convert.ToInt32(Console.Read());

if(number_one > number_two) Console.Write(number_one);
if(number_one < number_two) Console.Write(number_two);
if(number_one == number_two) Console.Write("Числа одинаковы");
