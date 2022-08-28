/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите размер массива (количество чисел в анализируемой выборке) М: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] analyzeNumbers = new double[size];

int countPositiveNumbers = 0;

for (int i = 0; i < size; i++)
{
    Console.WriteLine("Введите значение элемента массива: ");
    analyzeNumbers[i] = Convert.ToDouble(Console.ReadLine());

    if (analyzeNumbers[i] > 0) countPositiveNumbers++;
}

Console.WriteLine($"[{String.Join("; ", analyzeNumbers)}]");

Console.WriteLine($"Количество положительных чисел в выборке: {countPositiveNumbers}");