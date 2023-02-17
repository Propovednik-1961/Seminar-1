// Напишите программу , которая на вход принимает два числа и проверяет, яявляется ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2,  b = 10 -> нет
// a = 9,  b = -3 -> да
// a = -3, b = 9 ->  нет

// напишите программу , которая будет выдавать название дня недели по заданному номеру.
// 3 -> среда
// 5 -> пятница


Console.Write("Ведите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2*number2 )
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет"); 
}
