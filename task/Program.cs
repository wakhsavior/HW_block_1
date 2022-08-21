// Программа которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// корреляциями, лучше обойтись исключительно массивами

Console.WriteLine("Введите массив строк");
string[] source_array = { "Привет", "123", "Hello", "World", "cup", "of", "tea" };

int length_array = source_array.Length;
string[] new_array = new string[length_array];

int j = 0;

Console.WriteLine("Итоговый массив");

for (int i = 0; i < length_array; i++)
{
    if (source_array[i].Length <= 3)
    {
        new_array[j] = source_array[i];
        Console.Write($"{new_array[j]}\t");
        j++;
    }
}

