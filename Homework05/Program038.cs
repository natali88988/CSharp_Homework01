int count = 20;
double[] mas = new double[count];
Random rand = new Random();

for(int i=0; i<mas.Length; i++){
    mas[i] = Math.Round(rand.NextDouble() * 100, 2);
    Console.WriteLine($"Элемент массива № {i+1} равен {mas[i]}");
}

double maxValue = mas.Max();
double minValue = mas.Min();
double result = Math.Round(maxValue - minValue, 2);

Console.WriteLine($"\nМаксимальный элемент массива: {maxValue}\nМинимальный элемент массива: {minValue}");
Console.WriteLine($"\nРазность между максимальным и минимальным элементами массива: {result}");