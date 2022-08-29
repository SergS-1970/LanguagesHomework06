/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите коэффициенты углового уравнения (y = kx + b) для первой прямой");

Console.WriteLine("Отсечка по оси Y b1: ");
double cutoffAlongAxisYFirstStraight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Угловой коэффициент k1: ");
double slopeFirstStraight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите коэффициенты углового уравнения (y = kx + b) для второй прямой");

Console.WriteLine("Отсечка по оси Y b2: ");
double cutoffAlongAxisYSecondStraight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Угловой коэффициент k2: ");
double slopeSecondStraight = Convert.ToDouble(Console.ReadLine());

if (slopeFirstStraight == slopeSecondStraight &&
cutoffAlongAxisYFirstStraight == cutoffAlongAxisYSecondStraight)
{
    Console.WriteLine("Прямые совпадают");
}

else
{
    if (slopeFirstStraight == slopeSecondStraight &&
    cutoffAlongAxisYFirstStraight != cutoffAlongAxisYSecondStraight)
    {
        Console.WriteLine("Прямые параллельны и не имеют точек пересечения на плоскости");
    }

    else
    {
        double coordinateOfIntersectionX =
        Math.Round((cutoffAlongAxisYSecondStraight - cutoffAlongAxisYFirstStraight) /
        (slopeFirstStraight - slopeSecondStraight), 4);

        double coordinateOfIntersectionY =
        Math.Round(slopeFirstStraight * coordinateOfIntersectionX + cutoffAlongAxisYFirstStraight, 4);
        Console.WriteLine($"Координаты пересечения прямых: ({coordinateOfIntersectionX}; {coordinateOfIntersectionY})");
    }
}