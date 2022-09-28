Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void Cube(int N)
{
    Console.Write($"Таблица кубов чисел от 1 до {N}: ");
    for (int i = 1; i < N+1; i++)
    {
        int element = (int)(Math.Pow(i, 3));
        if (i < N) {Console.Write($"{element}, ");}
        else {Console.Write($"{element}.");}
    }
}

Cube(N);
