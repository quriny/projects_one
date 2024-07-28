int x = Convert.ToInt16(Console.ReadLine());
string result = "";
if (x < 1 || x > 99)
{
    Console.WriteLine("Ошибка");
}
else
{
    if (x <= 19)
    {
        switch (x)
        {
            case 1: result = "Один"; break;
            case 2: result = "Два"; break;
            case 3: result = "Три"; break;
            case 4: result = "Четыре"; break;
            case 5: result = "Пять"; break;
            case 6: result = "Шесть"; break;
            case 7: result = "Семь"; break;
            case 8: result = "Восемь"; break;
            case 9: result = "Девять"; break;
            case 10: result = "Десять"; break;
            case 11: result = "Одиннадцать"; break;
            case 12: result = "Двенадцать"; break;
            case 13: result = "Триннадцать"; break;
            case 14: result = "Четырнадцать"; break;
            case 15: result = "Пятнадцать"; break;
            case 16: result = "Шестнадцать"; break;
            case 17: result = "Семнадцать"; break;
            case 18: result = "Восемнадцать"; break;
            case 19: result = "Девятнадцать"; break;
        }
    }
    else
    {
        int a = x / 10; int b = x % 10;
        switch (a)
        {
            case 2: result = "Двадцать "; break;
            case 3: result = "Тридцать "; break;
            case 4: result = "Сорок "; break;
            case 5: result = "Пятьдесят "; break;
            case 6: result = "Шестьдесят "; break;
            case 7: result = "Семьдесят "; break;
            case 8: result = "Восемьдесят "; break;
            case 9: result = "Девяносто "; break;

        }
        switch (b)
        {
            case 1: result += "Один"; break;
            case 2: result += "Два"; break;
            case 3: result += "Три"; break;
            case 4: result += "Четыре"; break;
            case 5: result += "Пять"; break;
            case 6: result += "Шесть"; break;
            case 7: result += "Семь"; break;
            case 8: result += "Восемь"; break;
            case 9: result += "Девять"; break;
        }

    }
    Console.WriteLine(result);
}

