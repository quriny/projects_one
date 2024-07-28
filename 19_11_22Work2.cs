using System.Diagnostics;

namespace _191122.Homework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumDigits(x));
            while (x>9)
            {
                x = SumDigits(x);
            }
            Console.WriteLine(x);
        }
        //Сумма цифр в числе
        public static int SumDigits(int num)
        {
            int sum=0;
            while (num>0)
            {
                sum += num % 10;
                num /= 10;
            }
            num = sum;
            return num;
        }
        

    }
}