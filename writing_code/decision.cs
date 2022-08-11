// 1-й вариант решения.
int numOfArrayElements = 4;
string[] specifiedArray = new string[numOfArrayElements];

Console.WriteLine($"Задайте массив, Состоящий из {numOfArrayElements} эл-тов, включающий в себя любые цифры, буквы,\nсимволы или их последовательности.\n");

for (int i = 0; i < numOfArrayElements; i++)
{
    Console.Write($"Введите {i + 1}-й эл-т массива: ");
    specifiedArray[i] = Console.ReadLine();
}

int counter = 0;

for (int i = 0; i < specifiedArray.Length; i++)
{
    if (specifiedArray[i].Length <= 3) counter++;  //находим длину нового массива (counter) для вывода эл-тов.
}
Console.WriteLine();

if (counter == 0)
{
    Console.WriteLine("В заданном массиве нет элементов с длиной менее 4-х символов.");
}
else
{
    Console.Write("Создаем новый массив, в который войдут элементы заданного массива\nс длиной менее 4-х символов.\n[  ");

    string[] requiredArray = new string[counter]; // создаем новый массив.
    int newCounter = 0;

    for (int i = 0; i < specifiedArray.Length; i++)
    {
        if (specifiedArray[i].Length <= 3)
        {
            requiredArray[newCounter] = specifiedArray[i];
            Console.Write(requiredArray[newCounter] + "  ");
            newCounter++;
        }
    }
    Console.Write("]");
}

// 2-й вариант решения.

/*int numOfArrayElements = 4;
string[] specifiedArray = new string[numOfArrayElements];

Console.WriteLine($"Задайте массив, Состоящий из {numOfArrayElements} эл-тов, включающий в себя любые цифры, буквы,\nсимволы или их последовательности.\n");

for (int i = 0; i < numOfArrayElements; i++)
{
    Console.Write($"Введите {i + 1}-й эл-т массива: ");
    specifiedArray[i] = Console.ReadLine();
}

Console.Write($"Эл-ты заданного массива, с длиной менее 4-х символов, это: \n[  ");

for (int i = 0; i < specifiedArray.Length; i++)
{
    if (specifiedArray[i].Length <= 3) {
        Console.Write(specifiedArray[i] + "  ");
    }
}
Console.Write("]");
*/
