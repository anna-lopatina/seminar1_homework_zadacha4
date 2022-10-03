// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите три числа");
Console.Write("Введите первое число a = ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число b = ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число c = ");
int c = int.Parse(Console.ReadLine()!);
int max;
max = a;
if (a < b) {
    max = b;
} 
if (c > max) {
    max = c;
}
Console.WriteLine("max = {0}", max);