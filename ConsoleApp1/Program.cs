using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            int buff;
            createArr arr2 = new createArr();
            arr2.createArray(arr, 10);
            arr2.PrintArray(arr);
           

            for(int i=0;i<9;i++)
                for(int j = i + 1; j < 10; j++)
                    if (arr[i] > arr[j])
                    {
                        buff = arr[j];
                        arr[j] = arr[i];
                        arr[i] = buff;
                    }
            Console.WriteLine();
            arr2.PrintArray(arr);

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Вставки");
            Console.WriteLine();
            int[] array = new int[10];
            arr2.createArray(array, 10);
            arr2.PrintArray(array);
            Console.WriteLine();
            for (int i=1; i<10;i++)
            {
                int new_end = array[i];
                int j = i;
                while (j>0 && new_end < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = new_end;
            }

            arr2.PrintArray(array);


            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Слияние");
            Console.WriteLine();
            int[] arraymerge = new int[10];
            arr2.createArray(arraymerge,10);            
            arr2.PrintArray(arraymerge);
            arr2.MergeSort(arraymerge);
            Console.WriteLine(); Console.WriteLine();
            arr2.PrintArray(arraymerge);


            Console.ReadKey();
        }

        

       

        
    }
}
