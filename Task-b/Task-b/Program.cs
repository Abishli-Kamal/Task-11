using System;

namespace Task_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division ");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  input-1");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter input");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(input_1, input_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(input_1, input_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(input_1, input_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(input_1, input_2);
                        break;
                    }
                default:
                    Console.WriteLine("try again");
                    break;
            }
            Console.WriteLine("The result is {0}", result);

        }
          
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
          
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }
         
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
          
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            return result;


        }


    }
}


