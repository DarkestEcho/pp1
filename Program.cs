using System;
using System.Threading;

//Самарин Д.К. 17ПИ

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            string str=Console.ReadLine();
            new Thread(()=>{Summ(str);}).Start();  //т.к. нужно передать параметр в поток использую лямбду
       }

        static void Summ(string str)
        {
           
            

            try
            {
                int num = Convert.ToInt32(str);
                Console.WriteLine(num);
                if (num > 0)
                {
                    int max=num;
                    for (int i = 0; i < max; i++) 
                    {
                       
                        num += i;
                        Console.WriteLine($"Результат {i} итерации: {num}");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Результат суммирования: {num}\n");
                }
                else if (num < 0)
                {
                    int min=num;
                    int j=0;
                    for (int i = min; i < 0; i++) 
                    {
                       
                        num +=i;
                        Console.WriteLine($"Результат {j++} итерации: {num}");
                        
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Результат суммирования: {num}\n");
                }
                else
                    Console.WriteLine($"Результат суммирования: {num}");

                Console.Read();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error! {e.Message}");
                Console.Read();
            }

        }
    }
}
