//  программа, которая на вход принимает 2 числа и проверяет является ли первое квадратом второго.

// напрмер:
//4 -> 16
// -3 -> 9
// -7 -> 49
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine("your result is: " + result);
Console.WriteLine("Your result is: {0}", result);
Console.WriteLine($"Your result is {number * number}");



