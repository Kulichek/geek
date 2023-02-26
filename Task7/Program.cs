// Программа,которая принимает на входтрехзначные число и на выходепоказывает последнюю цифру этого числа

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int div = 0;

if(num => 100 && num < 1000)
{ 
    div = num % 10;
    Console.WriteLine(div);
}    
else 
{
    Console.WriteLine("Введите трёхзначное число");
}


