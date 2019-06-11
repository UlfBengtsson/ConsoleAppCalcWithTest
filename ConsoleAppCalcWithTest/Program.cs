using System;
using System.Text;

namespace ConsoleAppCalcWithTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calc");

            char[] cat = "cat".ToCharArray();

            string someText = ArrayToString(cat);

            Console.WriteLine(someText);
        }

        public static string ArrayToString(char[] charArray)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < charArray.Length; i++)
            {
                stringBuilder.Append(charArray[i]);
            }

            return stringBuilder.ToString();
        }

        public static double Add(double numA, double numB)
        {
            return numA + numB;
        }

        public static double Minus(double numA, double numB)
        {
            return numA - numB;
        }

        public static double Multi(double numA, double numB)
        {
            return numA * numB;
        }

        public static double Div(double numA, double numB)
        {
            return numA / numB;
        }
    }
}
