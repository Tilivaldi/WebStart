using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class createArr
    {

        public void createArray(int[] arr, int arrLenght)
        {
            Random rand1 = new Random();
            for (int i = 0; i < arrLenght; i++)
            {
                arr[i] = rand1.Next(10);
            }

        }

        public void PrintArray(int[] arr)
        {
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
        }

        public int[] MergeSort(int[] array)
        {
            if (array.Length > 1)
            {
                //массивы для хранения половинок входящего буфера
                int[] left = new int[array.Length / 2];
                //для проверки ошибки некорректного разбиения массива,
                //в случае если длина непарное число
                int[] right = new int[array.Length - left.Length];

                //заполнение субмассивов данными из входящего массива
                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = array[i];
                }
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = array[left.Length + i];
                }
                //если длина субмассивов больше еденици,
                //то мы повторно (рекурсивно) вызываем функцию разбиения массива
                if (left.Length > 1)
                    left = MergeSort(left);
                if (right.Length > 1)
                    right = MergeSort(right);
                //сортировка слиянием половинок
                array = Merge(left, right);
            }
            //возврат отсортированного массива
            return array;
        }


        public int[] Merge(int[] left, int[] right)
        {
            int[] array = new int[left.Length + right.Length];
            int i = 0;
            int l = 0;
            int r = 0;
            for (int x=0; x < array.Length; x++)
            {
                if (r >= right.Length)
                {
                    array[x] = left[l];
                    l++;
                }
                else if (l < left.Length && left[l] < right[r])
                {
                    array[x] = left[l];
                    l++;
                }
                else
                {
                    array[x] = right[r];
                    r++;
                }
            }
            return array;
        }
    }
}