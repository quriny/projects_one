//namespace _071222.Classwork
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //ввод адреса нужной папки
//            Console.WriteLine("Введите адрес папки");
//            string s = Console.ReadLine();
//            //вызов функции для вывода папок и подпапок
//            ShowAllInFolder(s);
//        }
//        //функия которая показывает содержимое папки и всех ее попдпапок
//        static void ShowAllInFolder(string sSAIF, int count = 0)
//        {
//            if (count==0)
//            {

//            }
//        }
//    }
//}  
//            //string PathToFolder = Console.ReadLine();
//            //string[] allfiles = Directory.GetFiles(PathToFolder);
//            //foreach (string filename in allfiles)
//            //{
//            //    Console.WriteLine(filename);
//            //}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FilePath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа проверяет наличие файлов в папке и, если они они есть, выводит на экран их имена");
            Console.Write("Введите имя папки: ");
            string folder = Console.ReadLine();
            if (Directory.Exists(folder))
            {
                PrintFiles(folder);
            }
            else
            {
                Console.WriteLine("Файлы не найдены");
            }
            Console.WriteLine("Нажмите любую клавишу для выхода из  программы");
            Console.ReadKey();
        }
        public static void PrintFiles(string path, int lvl = 0) //выводит все элементы, находящиеся в исходной папке
        {
            if (lvl == 0) //относится только к исходной папке
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Path.GetFullPath(path)); //выводит путь исходной папки
            }
            else
            {
                if (Directory.GetFileSystemEntries(path).Any()) //проверяет, имеются ли подкаталоги
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(new string(' ', lvl * 2) + $"+ {Path.GetFileName(path)}");
                }
            }
            lvl++;
            Console.ResetColor();
            foreach (string file in Directory.GetFiles(path)) //выполнение для каждого элемента в текущем подкаталоге
            {
                Console.WriteLine(new string(' ', lvl * 2) + $"L {Path.GetFileName(file)}");
            }
            foreach (string fold in Directory.GetDirectories(path)) //выполнение для каждого подкаталога, рекурсия
            {
                PrintFiles(fold, lvl);
            }
        }
    }
}
