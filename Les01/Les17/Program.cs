// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


        void array(int[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = new Random().Next(100, 999);
                Console.Write($" {number[i]} ");
            }
        }

        int arr(int[] get)
        {
            int qwerty = 0;
            for (int index = 0; index < get.Length; index++)
            {
                if (get[index] % 2 == 0)
                {
                    qwerty++;
                }
            }
            return qwerty;
        }

        Console.Clear();
        int[] red = new int[4];
        array(red);
        Console.WriteLine($"Количество четных элементов {arr(red)}");