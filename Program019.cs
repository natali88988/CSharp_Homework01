Console.Write("Введите количество цифр в числе: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите число, состоящее из {size} цифр: ");
string value = Console.ReadLine();

void CheckValue (int size, string value)
{
    int element = 0;
    int end = 0;
    int palindrom = 0;
    int count = size/2;

    for (int i=0; i<count; i++) 
    {
        element = Convert.ToInt32(value[i]);
        end = Convert.ToInt32(value[size-1]);
        if (element == end) 
        {
            palindrom++;
            size--;
        }
    }

    if (palindrom == count) {Console.Write($"Число {value} является палиндромом");}
    else {Console.Write($"Число {value} не является палиндромом");}
}

if (value.Length == size) {CheckValue(size, value);}
else {Console.Write($"Введенное число состоит не из {size} цифр");}

