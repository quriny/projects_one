//s = new string('*', 5); --> *****

int m, n, k;
string sp, sz;
//m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input n");
//n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input m");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k");
k = Convert.ToInt32(Console.ReadLine());

//elka
for (int mi = 1; mi <= m; ++mi)
{
    for (int i = 1; i <= k * 2 - 1; i += 2)
    {
        sp = new string(' ', (k * 2 - i - 1) / 2);
        sz = new string('*', i);
        Console.Write(sp);
        Console.Write(sz);
        Console.WriteLine();

    }
    sp = new string(' ', k - 1);
    sz = new string('*', 1);
    Console.Write(sp);
    Console.Write(sz);
    Console.WriteLine(' ');
}
//int m, n, k;
//Console.WriteLine("input m") ;
//m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("input n");
//n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("input k");
//k = Convert.ToInt32(Console.ReadLine());
//string s;
//for (int i=1; i <= n; ++i)
//{
//    s = new string(' ', k - n);
//    Console.Write(s);
//    s = new string('*', k);
//    Console.Write(s);
//    s = new string(' ', k-n);
//    Console.Write(' ');
//}






