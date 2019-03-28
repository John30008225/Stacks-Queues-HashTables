using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q1 = new Queue();
            Queue q2 = new Queue();


            string input = "y";

            do
            {
                Console.WriteLine("\nEnter name");
                q1.Enqueue(Console.ReadLine());
                
               Console.WriteLine("\nChuck another name in?  (y/n): ");
               input = Console.ReadLine();
                              
            } while (input == "y");



            do
            {
                q2.Enqueue(q1.Peek());
                Console.WriteLine("\nName " + q1.Dequeue());                     


            } while (q1.Count !=0);
            Console.WriteLine("\nFind a name in the Queue ");
                        
            input = Console.ReadLine();
            if (q2.Contains(input) == true)
            {
                while (q2.Peek().ToString() != input)
                {
                    q2.Dequeue();
                }


                Console.WriteLine($"\nQueue contains the value {q2.Peek()}");
            }
            else
            {
                Console.WriteLine("\nDoes not contain the Name" + input);
            }

            Console.WriteLine(q2.Peek());
            

            Console.WriteLine("\nAwesome! Have as wicked day");
            Console.ReadLine();
        }
              
    }
}
