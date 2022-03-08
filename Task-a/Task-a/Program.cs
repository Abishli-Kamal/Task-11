using System;

namespace Task_a
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Divison();

        }
        public static int Divison()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 7 == 0)
            {
                Console.Write("7 e bolunur  ");
            }


            else if (number % 7 == 1)
            {
                Console.WriteLine(number - 1);
            }
            else if (number % 7 == 2)
            {
                Console.WriteLine(number - 2);
            }
            else if (number % 7 == 3)
            {
                Console.WriteLine(number - 3);
            }
            else if (number % 7 == 4)
            {
                Console.WriteLine(number + 3);
            }
            else if (number % 7 == 5)
            {
                Console.WriteLine(number + 2);
            }
            else if (number % 7 == 6)
            {
                Console.WriteLine(number + 1);
            }
            return number;
        }
    }
}
