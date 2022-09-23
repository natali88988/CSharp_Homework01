Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b) Console.WriteLine($"Наибольшее число: {a}, наименьшее число: {b}");
else 
{  if (a<b) Console.WriteLine($"Наибольшее число: {b}, наименьшее число: {a}");
   else Console.WriteLine($"Числа {a} и {b} равны");
}
