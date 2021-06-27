using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.HW.question2
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] dblArr = { 3, 4, 7, 8, 4, 2, 6, 8, 7, 5 };


            int count = 0;
            for (int i = 0; i < 30; i++)
            {
                
                int index = Array.IndexOf(dblArr, 3);

                Console.WriteLine("Enter number");
                int num = int.Parse(Console.ReadLine());
                
                int index2 = Array.IndexOf(dblArr, num);
                if (index2 == index)
                {
                    
                    Console.WriteLine(index2);
                    Console.WriteLine("Correct,you found the number after {0} attemtps", count);
                }
                else
                {
                    Console.WriteLine("try again");
                    count++;
                }
            if(i == 29)
                {
                    Console.WriteLine("too my attemtps {0}, exiting", count);

                    Console.ReadLine();
                    break;
                }
            
            }



        }
    }
}
