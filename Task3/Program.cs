// Программа, которая будет выдавать название дня недели по заданному числу

// 3-> среда
// 6-> пятница

Console.WriteLine("Введите день недели");
int num = Convert.ToInt32(Console.ReadLine());
switch (num) {
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("вторник");
        break;
    case 3:
        Console.WriteLine("среда");
        break;
    case 4:
        Console.WriteLine("четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Такого значения не существует");
        break;
}



