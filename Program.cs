// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []*



    Console.Clear();
    Console.WriteLine("Программа, формирующая новый массив из строк, длина которых меньше или равна 3 символам.");

    Console.Write("Введите размер массива: ");
    int size;
    while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
    {
        Console.WriteLine("Некорректный ввод. Повторите попытку.");
        Console.Write("Введите размер массива: ");
    }

    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива {i + 1}: ");
        array[i] = Console.ReadLine();
    }

    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

    Console.WriteLine();

    Console.WriteLine("Новый массив:");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.WriteLine(array[i]);
        }
    }

