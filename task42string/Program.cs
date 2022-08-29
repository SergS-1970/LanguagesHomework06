/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

Console.WriteLine("Введите натуральное число N: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string binaryNumber = "";
int N = decimalNumber;

while (N >= 1)
{
    if (N % 2 == 1) binaryNumber = "1" + binaryNumber;
    else binaryNumber = "0" + binaryNumber;
    N /= 2;
}

Console.WriteLine($"Число {decimalNumber} в двоичной форме: {binaryNumber}");
