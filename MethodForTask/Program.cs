﻿// дан текст. в тексте пробелы нужно заменить черточками, маленькие буквы к заменить больштми к,а большие с заменить маленькими с

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty" - если будет строка то ей нужен вспомогательный функционал. если нужно обратиться к определенному символу строки
//             012345 
// мы будем делать это начиная  отсчитывать символы с 0
//s[3] чтобы получить конкретный символ мы обращаемся через квадратные скобки к идентификатору строки,например 3 это будет r

//приступаем к коду. метод у нас принимает строку и те символы,которые надо будет менять старый на новый

string Replace(string text, char oldValue, char newValue)  //указали
{
    string result = string.Empty; //сразу заводим новую строку. она будет пустой

    int length = text.Length; // получаем длину нашей строки при помощи обращения к свойству
                              // показывающему колличество символов в строке
    for (int i = 0; i < length; i++)//пробегаемся от нулевого символа до конца строки
    {
        if(text[i] == oldValue) result = result + $"{newValue}";//если текст совпал со старым символом,которы мы хотим заменить то мы кладем его в новый
        else result = result + $"{text[i]}";// если совпадений не обнаружено то в наш резалт нужно добавить текущий символ который и был
    }
    return result; //сразу возвращаем в метод
}                 
string newText = Replace(text, ' ', '|');//пробел обрамляется как символ одинарные скобки
Console.WriteLine(newText);
Console.WriteLine();
string newText2 = Replace(text, 'к', 'К');
Console.WriteLine(newText2);
Console.WriteLine();
string newText3 = Replace(text, 'с', 'С');
Console.WriteLine(newText3);
