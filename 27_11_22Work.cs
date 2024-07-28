namespace _271122.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Считываем массив, элементы типа int
            int[] array = Console.ReadLine().Split(", ").Select(number => Convert.ToInt32(number)).ToArray();
            //Находим цену 1го тире
            double costone = (double)(array[0] - (array.Length - 2)) / (double)(array.Sum() - array[0]);
            string s;
            string result="";
            //Формируем строку
            for (int i=1; i<array.Length;++i)
            {
                if ((int)Math.Round(array[i] * costone) >= 1)
                {
                    s = new string('-', (int)Math.Round(array[i] * costone));
                    if (i != array.Length - 1)
                    {
                        s += '|';                        
                    }
                    result += s;
                }
                else
                {
                    Console.WriteLine("Error!");
                    result = "";
                    break;
                }
            }
            //Выводим результат
            Console.WriteLine(result);
        }
    }
}     
