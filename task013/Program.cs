Console.Write("Введите число: ");
string value = Console.ReadLine();
if (value.Length > 2) 
{
    Console.WriteLine($"Третья цифра числа {value} равна {value[2]}");
}
else
{
    Console.WriteLine("Третьей цифры у введенного числа нет");
}
