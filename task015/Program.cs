Console.Write("Введите цифру, обозначающую день недели: ");
int value = Convert.ToInt32(Console.ReadLine());

if (value > 0 && value <= 7) 
{
    if (value == 6 || value == 7) 
    {
        Console.WriteLine($"День недели № {value} является выходным");
    }
    else
    {
        Console.WriteLine($"День недели № {value} не является выходным");
    }
}
else
{
    Console.WriteLine($"Дня недели № {value} не существует");
}


