using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();

            Console.WriteLine("Please Enter Value: ");      // Chuck in a loop to simplify
            s1.Push(Console.ReadLine());
            Console.WriteLine("Please Enter Value: ");      //
            s1.Push(Console.ReadLine());
            Console.WriteLine("Please Enter Value: ");      //
            s1.Push(Console.ReadLine());
            Console.WriteLine("Please Enter Value: ");      //
            s1.Push(Console.ReadLine());
            Console.WriteLine("Please Enter Value: ");      //
            s1.Push(Console.ReadLine());

            Console.WriteLine("Check for a specific value: ");
            string input = Console.ReadLine();

            
            if (s1.Contains(input) == true)
            {
                while (s1.Peek().ToString() != input)
                {
                    s1.Pop();
                }
                

                Console.WriteLine($"Stack contains the value {s1.Peek()}");
            }
            else
            {
                Console.WriteLine("Does not contain the value");
                                
            }
           
            Console.ReadLine();     
        }
    }
}
