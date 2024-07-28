using System.Diagnostics.Metrics;

Console.WriteLine("Введите значение угла x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение точности e");
double e = Convert.ToDouble(Console.ReadLine());
double cosx = 1;
double zfact = 2;
double fact = 2;
double z=1;
short count = 0;
while (true)
{
    count += 1;
    z = -z*x*x/zfact;                          
    cosx = cosx+z;                             
    if (Math.Abs(z) < e && count>=3)
    {
        break;
    }
    fact += 2;                                 
    zfact = zfact * (fact-1) * fact;           
}
Console.WriteLine(cosx);
