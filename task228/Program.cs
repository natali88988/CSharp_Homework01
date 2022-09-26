Console.WriteLine("Необходимо ввести 7 чисел");

float sum = 0;
int value_i = 0;

for (int i = 0; i < 7; i++)
{
    Console.Write($"Введите число № {i+1}: ");
    value_i = Convert.ToInt32(Console.ReadLine());
    sum = sum + value_i;
}

float average_value = sum/7;
Console.WriteLine($"Среднее арифметическое из 7 введенных чисел равно {average_value}");
