Console.WriteLine("Input x");
string str;
str = Console.ReadLine();
double x = Convert.ToDouble(str);

double N; 
string B;
string S; 

if (x <= 36)
{
    N = Math.Ceiling(x / 4);
    B = "К";
    if (x%2==0)
    {
        S = "В";
    }
    else
    {
        S = "Н";
    }
}
else
{
    N = Math.Ceiling((54-x+1)/2);
    B = "Б";
    if (x%2==0)
    {
        S = "В";
    }
    else
    {
        S = "Н";
    }
}
string Result = Convert.ToString(N)+B+S;
Console.WriteLine(Result); 

