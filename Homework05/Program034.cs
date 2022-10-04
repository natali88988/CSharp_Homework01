int count = 80;
int[] mas = new int[count];
Random rand = new Random();
int result = 0;

for(int i=0; i<mas.Length; i++){
    mas[i] = rand.Next(100, 1000);
    Console.WriteLine($"Элемент массива № {i+1} равен {mas[i]}");
}

for(int i=0; i<mas.Length; i++){
    if(mas[i] % 2 == 0) { result++; }
}

Console.WriteLine($"\nКоличество четных элементов массива: {result}");

