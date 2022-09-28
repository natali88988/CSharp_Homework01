Console.WriteLine("Координаты первой точки");
Console.Write("Введите X координату первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nКоординаты второй точки");
Console.Write("Введите X координату второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

float Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int distX = Convert.ToInt32(Math.Pow(x2-x1, 2));
    int distY = Convert.ToInt32(Math.Pow(y2-y1, 2));
    int distZ = Convert.ToInt32(Math.Pow(z2-z1, 2));

    float sum = (float)(distX + distY + distZ);
    float dist = (float)(Math.Sqrt(sum));
    dist = (float)Math.Round(dist, 2);

    return dist;
}

Console.Write($"\nРасстояние между двумя точками равно {Distance(x1, y1, z1, x2, y2, z2)}");