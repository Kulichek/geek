﻿//даны числа 68321457      
//1. найти позицию минимального элемента в неотсортированной части массива
//2. произвести обмен этого значения со значением первой неотсортированной позиции
//3. повторять пока есть не отсортированные элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};//массив который будем отсортировывать

void PrintArray(int[] array) //метод воид.в качестве аргумента будет приходить массив
{
    int count = array.Length;                   //получение количества элементов. даются разные названия

    for (int i = 0; i < count; i++)//пробегаем по всем элементам в массиве и показываем на экране
    {
     Console.Write($"{array[i]} ");
    }   
    Console.WriteLine();
}

void SelectionSoft(int[] array) //метод, который будет упорядочивать наш массив
{
    for (int i = 0; i < array.Length - 1 ; i++) //пробежка по массиву
     {
        int minPosition = i;//переменная с минимальной позицией указываем тот самый элемент с которым будем проводить действия

        for (int j = i + 1; j < array.Length; j++) //этот блок кода ищет минимальный элемент
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i]; //нам потребуется поменять значение нашей позиции с той позицией, которую нашли
        array[i] = array[minPosition];                   //позиция будет вычисляться индексом i
        array[minPosition] = temporary; //если мы начинаем поиск элемента от i + 1 где i меняется до максимального значения нашей позиции
                                        //нашего массива то в этом случае нужно искусственно единичку отнять в 21 строке у ленс
                                        //тогда i+1 даст максимальное колличество элементов
     }
}         
PrintArray(arr);
SelectionSoft(arr);

PrintArray(arr);

 

 