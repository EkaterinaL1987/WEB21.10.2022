  //Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
  int[] arr = new int[12];
            int k = 0, sum = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < 12; i++)
            {
                arr[i] = rnd.Next(-50, 50);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив ");
            Array.Sort(arr);
 
            foreach(int element in arr)
            {
                Console.Write("{0} ", element);
                if (element % 2 == 0)
                {
                    k++;
                    sum += element;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов {0}, сумма четных элементов {1}", k, sum);
            

