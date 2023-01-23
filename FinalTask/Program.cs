// Написать программу, которая из имеющегося массива строк формирует массив из, 
// длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


// Метод определения элементов в массиве, длина которых меньше либо равна 3 символам.
void ArrayOf3Сharacters (string [] array1, string [] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

// Метод печати массива
void PrintArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();
string [] array1 = new string [4] {"hello", "2", "world", ":-)"};
string [] array2 = new string [array1.Length];
ArrayOf3Сharacters (array1, array2);
PrintArray (array2);