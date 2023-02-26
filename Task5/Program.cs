// Программа,которая на вход прирнимает одно число N , а на выходе показывает все целые числа в промежутке от N до -N
//4->"-4,-3,-2,-1,0,1,2,3,4"
//2->"-2,-1,0,1,2"

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int count = num * -1;

while (count <= num) {
    Console.WriteLine(count);
    count = count + 1;
}
