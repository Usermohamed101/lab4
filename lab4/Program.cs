using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task1
            //int noperson;
            //Console.WriteLine("enter the number of people");
            //int x=int.Parse(Console.ReadLine());

            //string[] names=new string[x];
            //int[] ages=new int[x];
            //int i = 0;
            //while (i<x)
            //{
            //    Console.WriteLine($"enter the the name number {i+1}");
            //    names[i] = Console.ReadLine();
            //    Console.WriteLine($"ennter the age ");
            //    ages[i]=int.Parse(Console.ReadLine());


            //    i++;
            //}
            //Console.WriteLine("enter the number of person you wanna print its data");
            //noperson = int.Parse(Console.ReadLine());
            //Console.WriteLine($"the name is {names[noperson-1]}");
            //Console.WriteLine($"the age is {ages[noperson-1]}");

            #endregion


            #region task2
            Console.WriteLine("enter the integer array");
            string arr_int=Console.ReadLine();
            string[] arr_int_split = arr_int.Split(',');
            int[] numbers = new int[arr_int_split.Length];
            int[] numbers_product = new int[arr_int_split.Length];
            for (int i = 0; i < arr_int_split.Length; i++)
            {
                numbers[i] = int.Parse(arr_int_split[i]);

            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 1;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] != numbers[i])
                        sum *= numbers[j];
                }
                numbers_product[i] = sum;
            }
            Console.Write("[");
            for (int i = 0; i < numbers_product.Length; i++)
            {
                Console.Write(numbers_product[i]);
                if (i < numbers_product.Length - 1)
                {
                    Console.Write(",");
                }

            }
            Console.Write("]");
            #endregion



            Console.ReadKey();





        }
    }
}
