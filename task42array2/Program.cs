/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

Console.WriteLine("Введите натуральное число N: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

int auxiliaryN = decimalNumber;

int binaryDigitCalculation = Convert.ToInt32(Math.Floor(Math.Log2(decimalNumber)) + 1);

int[] binaryNumber = new int[binaryDigitCalculation];

for (int i = binaryDigitCalculation - 1; i >= 0; i--)
{
    binaryNumber[i] = auxiliaryN % 2;
    auxiliaryN /= 2;
}

Console.WriteLine($"Число {decimalNumber} в двоичной форме: {String.Join("", binaryNumber)}");
