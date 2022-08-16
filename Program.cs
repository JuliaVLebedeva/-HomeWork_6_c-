

void Zadacha41()
{
    // Задача 41. Пользователь вводит с клавиатуры M чисел. 
    //Посчитайте, сколько чисел больше 0 ввёл пользователь.

    Console.WriteLine("Сколько чисел нужно ввести?");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for (int i = 0; i < m; i++) 
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if(number > 0) count++;
    }
    Console.WriteLine($"Введено {count} чисел(-ло) больше нуля");
}
//Zadacha41();


void Zadacha43()
{
// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine ("Введите коэффициент k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите коэффициент k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
Console.WriteLine ($"Первая точка х равна {x}");
double y = k1*x+b1;
Console.WriteLine ($"Вторая точка y равна {y}");
Console.WriteLine ("Точка пересечения 2-х прямых с заданными коэффициентами k и b имеет координаты:  ("+x+","+y+")");
}
//Zadacha43();


