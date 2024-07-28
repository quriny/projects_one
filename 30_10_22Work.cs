char x = Convert.ToChar(Console.ReadLine());
x = Char.ToLower(x); 
if (x >= 'А' && x <= 'я') 
{
    switch (x)
    {
        case 'а':case 'е':case 'ё':case 'и':case 'о':
        case 'у':case 'ы':case 'э':case 'ю':case 'я':
            Console.WriteLine("Гласная") ;
            break;
        default:
            Console.WriteLine("Согласная");
            break;
    } 
}
else
{
    Console.WriteLine("Error");
}

