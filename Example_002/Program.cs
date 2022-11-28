// Имеется одномерный массив array из n элементов. Требуется найти элемент массива равный find.
void FillArray(int[] collection) // функция, заполняющая массив рандомными числами
{
    int length = collection.Length; // Получаем длинну массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index = index++;
    }
}

void PrintArray(int[] col)  // функция вывода на экран значения элементов массива
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) // Выводу нужного элемента массива
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // в случае нахождения элемента, необходимо будет сохранить позицию
    while (index<count)
    {
        if (collection[index]==find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];// создай новый массив размерностью 10

FillArray(array);
PrintArray(array);

Console.WriteLine();    
int pos=IndexOf(array,444); // вводим значение элемента массива для поиска элемента массива, который хотим вывести на экран
Console.WriteLine(pos);
