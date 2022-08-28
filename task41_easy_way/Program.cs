/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите количество чисел - элементов анализируемой выборки М: ");
int amountNumbers = Convert.ToInt32(Console.ReadLine());

int countPositiveNumbers = 0;

for (int i = 1; i <= amountNumbers; i++)
{
    Console.WriteLine("Введите число: ");
    double sampleNumber = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Осталось ввести чисел: {amountNumbers - i}");

    if (sampleNumber > 0) countPositiveNumbers++;
}

Console.WriteLine($"Количество положительных чисел в выборке: {countPositiveNumbers}");
