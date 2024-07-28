using System.Security.Cryptography.X509Certificates;

int sum = 0;
int count = 0;
int x;
while (true)
{
    Console.WriteLine("Input x");
    x = Convert.ToInt32(Console.ReadLine());
    if (x == 0)
    {
        break;
    }
    ++count;
    sum += x;
}
double sa = (double)sum / (double)count;
Console.WriteLine(sa);

