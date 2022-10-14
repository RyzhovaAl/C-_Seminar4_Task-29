// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

    int[] array = new int[8]; 
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число: ");
        array[i] = int.Parse(Console.ReadLine()!); 
    }

    Console.Write("Вывод массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        // if(array[i] > 0)
        Console.Write($"{array[i]}");
        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }


