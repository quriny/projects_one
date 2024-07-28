using System.Security.Cryptography;

namespace _181222.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //инициализация границ по умолчаию
            int min = 0, max = 100;
            //возможность пользователя изменить границы
            Console.WriteLine("Если хотите изменить границы нажмите A, иначе нажмите Enter");
            if (Console.ReadKey(true).Key == ConsoleKey.A)
            {
                Console.WriteLine("Введите нижнюю границу");
                min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите верхнюю границу");
                max = Convert.ToInt32(Console.ReadLine());
            }
            //предложение запуска функции
            Console.WriteLine("Для того, чтобы получить случайное число кратное d - нажмите A");
            if(Console.ReadKey(true).Key == ConsoleKey.A)
            {
                //ввод значения d пользователем
                Console.WriteLine("Введите значение d");
                int d = Convert.ToInt32(Console.ReadLine());
                //вывод результата работы функции
                Console.WriteLine(RandomNum(min, max, d));
            }
        }
        //функция генерирующая число из заданного промежутка, кратное d
        static int RandomNum(int minRN, int maxRN, int dRN)
        {
            int number;
            Random rnd = new Random();
            do
            {
                number= rnd.Next(minRN, maxRN+1);
            }while (number%dRN!=0) ;
            return number;
        }

    }
}