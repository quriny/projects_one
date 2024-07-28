short x, newx;
short count = 1, maxcount = 1;
x = Convert.ToInt16(Console.ReadLine());
if (x!=0)
{
  while (true)
  {
    newx = Convert.ToInt16(Console.ReadLine());
    if (newx == 0)
    {
            break;
    } 
    if (newx==x)
    {
            ++count;
            if (count>maxcount)
            {
                maxcount = count;
            }
    }
        else
        {
            count = 1;
        }
        x = newx;
   }
Console.WriteLine(maxcount);
}

