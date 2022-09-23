Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>=b && a>c) Console.WriteLine($"Наибольшее число: {a}");
if (b>a && b>=c) Console.WriteLine($"Наибольшее число: {b}");
if (c>=a && c>b) Console.WriteLine($"Наибольшее число: {c}");
if (a==b && b==c) Console.WriteLine($"Числа {a}, {b} и {c} равны");