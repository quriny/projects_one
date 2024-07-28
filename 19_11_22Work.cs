int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int k = Convert.ToInt32(Console.ReadLine());
string s;
for (int rows = 1; rows<=m ;++rows) {
    for (int res = 1; res <= k * 2 - 1; res += 2) {
        for (int cols = 1; cols <= n; ++cols) {
            s = new string(' ', ((k * 2 - 1) - res) / 2);
            Console.Write(s);
            s = new string('#', res);
            Console.Write(s);
            s = new string(' ', ((k * 2 - 1) - res) / 2);
            Console.Write(s);
            Console.Write(' ');
        }
        Console.WriteLine();
    }
    for (int cols = 1; cols <= n; ++cols) {
        s = new string(' ', k - 1);
        Console.Write(s);
        s = new string('#', 1);
        Console.Write(s);
        s = new string(' ', k - 1);
        Console.Write(s);
        Console.Write(' ');
    }
    Console.WriteLine();
    Console.WriteLine();
}



