Console.WriteLine("Введите объем");
double volume = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите скорость М");
double speed1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите скорость В");
double speed2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите процест усталости");
double pr1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите процент увеличения скорости заполнения");
double pr2 = Convert.ToDouble(Console.ReadLine());
speed1 = speed1 / 3;
speed2 = speed2 / 3;
double time = 0;
while (true)
{
    ++time;
    if (volume <= 0)
    {
        break;
    }
    volume = volume - Math.Abs(speed1 - speed2);
    speed1 = speed1 * (1 - pr1 / 100);
    speed2 = speed2 * (1 + pr2 / 100);
}
time = Math.Ceiling(time / 3);
Console.WriteLine(time);



