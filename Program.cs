// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//   лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] inputArray = { "Hello", "5", "world", "YES" };

// Фильтрация коротких строк
string[] shortStrings = FilterShortStrings(inputArray);

// Вывод результатов
Console.WriteLine("Результат:");
foreach (string str in shortStrings)
{
    Console.WriteLine(str);
}

string[] FilterShortStrings(string[] inputArray)
{
    // Подсчет количества коротких строк
    int shortStringCount = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            shortStringCount++;
        }
    }

    // Создание нового массива для коротких строк
    string[] shortStrings = new string[shortStringCount];
    int index = 0;

    // Фильтрация и заполнение нового массива короткими строками
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            shortStrings[index] = inputArray[i];
            index++;
        }
    }

    return shortStrings;
}
