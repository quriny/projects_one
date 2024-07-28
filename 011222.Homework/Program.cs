//на вход функции подается только строка
//функция возвращает true или false 
//не переворачивает строку

using System.ComponentModel.Design;

namespace _011222.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string s = Console.ReadLine();           
            if (CheckString(s))
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("Не палиндром");
            }
        }
        static bool CheckString(string sCS)
        {
            bool result;
            do
            {
                if (sCS[0] == sCS[sCS.Length-1])
                {
                    result = true;
                    sCS = sCS.Substring(1, sCS.Length - 2);
                }
                else
                {
                    result = false;
                    break;
                }
            } while (sCS.Length>1);
            return result;
        }
    }
}