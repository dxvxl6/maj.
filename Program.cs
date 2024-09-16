
using System;
class Program
{
    static void Main(string[] args)
    {
        int size = 20; // Размер массива
        int[] array = GenerateRandomArray(size, 1, 5); // Генерация массива с числами от 1 до 5
        Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));

        int majorityElement = FindMajorityElement(array);

        if (majorityElement != -1)
        {
            Console.WriteLine("Мажоритарное число: " + majorityElement);
        }
        else
        {
            Console.WriteLine("Мажоритарного числа нет.");
        }
    }

    static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }
        return array;
    }

    static int FindMajorityElement(int[] nums)
    {
        int candidate = -1;
        int count = 0;

        // Первый этап — поиск кандидата
        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                candidate = nums[i];
                count = 1;
            }
            else if (nums[i] == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        // Второй этап — проверка кандидата
        count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == candidate)
            {
                count++;
            }
        }

        if (count > nums.Length / 2)
        {
            return candidate;
        }
        else
        {
            return -1; // Мажоритарного числа нет
        }
    }
}
