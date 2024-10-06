using System;

class Program
{
    static void Main()
    {
        // Задаем произвольные значения из областей допустимых значений
        double a = 1.5;
        double b = 2.0;
        double t = 3.0;

        // Вычисляем значения y и s
        double y = CalculateY(a, b, t);
        double s = CalculateS(a, b, t);

        // Выводим результаты на экран
        Console.WriteLine("y = e^(-bt) * sin(at + b) - √|bt + a| = " + y);
        Console.WriteLine("s = b * sin(at^2 * cos(2t)) - 1 = " + s);
    }

    static double CalculateY(double a, double b, double t)
    {
        return Math.Exp(-b * t) * Math.Sin(a * t + b) - Math.Sqrt(Math.Abs(b * t + a));
    }

    static double CalculateS(double a, double b, double t)
    {
        return b * Math.Sin(a * Math.Pow(t, 2) * Math.Cos(2 * t)) - 1;
    }
}
