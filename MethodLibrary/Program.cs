void Fillarray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)//введем метод который будет печатать массива void метод, который ничего не возвращает и не нужен ретюрн
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}                 

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;// по умолчанию если элемента нет

    while(index < count)
    {
        if(collection[index] == find)
        {
                  position = index;
                  
        }
         index++;
    }     
    return position;
}

int[] array = new int[10]; //создадим новый массив и обозначим,что в нем 10 элементов команда new int []. по умолчанию он будет наполнен нулями. для этого вверх
Fillarray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
