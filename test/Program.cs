// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] FormationArray(string[] array, int value, int length = 0)
{
    string[] temp = new string[length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= value)
        {
            if (temp.Length > 0 && j < temp.Length)
            {
                temp[j] = array[i];
                j++;
            }
            length++;
        }
    }

    if (length > 0 && temp.Length <= 0) 
    {
      return FormationArray(array, value, length);  
    }
    return temp;
}

string Entry(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine()?? String.Empty;
}

string[] FillArrayAnyValue(int lenght)
{
    string[] arr = new string[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Entry($"Введите любое значение в {i+1}-й элемент массива");
    }
    return arr;
}

int lenght = Convert.ToInt32(Entry("Введите длину массива "));

int value = Convert.ToInt32(Entry("Введите длину строки для формирования "));

string[] arr = FillArrayAnyValue(lenght);

Console.Write($"[{string.Join(", ", arr)}] -> [{string.Join(", ",FormationArray(arr, value))}]");