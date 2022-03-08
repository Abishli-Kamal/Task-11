using System;

namespace Task_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eight();
        }
        public static int Three()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i += 3)
            {
                if (number < 50)
                {
                    Console.WriteLine(i);
                }
            }
            return number;
        }
        public static int Five()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i += 5)
            {
                if (number > 50 && number < 100)
                {
                    Console.WriteLine(i);
                }
            }
            return number;
        }
        public static int Eight()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i += 8)
            {
                if (number > 100)
                {
                    Console.WriteLine(i);
                }
            }
            return number;
        }
    }
}
