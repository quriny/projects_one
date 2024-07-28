namespace _061222.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ввод данных
            Console.WriteLine("Введите координаты первой вершины");
            Console.Write("x1:");
            int x1=Convert.ToInt32(Console.ReadLine());
            Console.Write("y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите координаты второй вершины");
            Console.Write("x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите координаты третьей вершины");
            Console.Write("x3:");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y3:");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Введите координаты точки");
            Console.Write("xA:");
            int xA = Convert.ToInt32(Console.ReadLine());
            Console.Write("yA:");
            int yA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //уравнения прямых
            int p1 = (x1-xA)*(y2-y1)-(x2-x1)*(y1-yA);
            int p2 = (x2-xA)*(y3-y2)-(x3-x2)*(y2-yA);
            int p3 = (x3-xA)*(y1-y3)-(x1-x3)*(y3-yA);
            //проверка на нахождение точки в треугольнике
            if ((p1<=0 && p2 <= 0 && p3 <= 0) || (p1 >= 0 && p2 >= 0 && p3 >= 0))
            {
                Console.WriteLine("Точка в треугольнике");
            }
            else
            {
                Console.WriteLine("Точка вне треугольника");
            }

        }
    }
}