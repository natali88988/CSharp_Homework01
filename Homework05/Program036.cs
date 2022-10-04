int count = 4;
int[] mas = new int[count];
Random rand = new Random();
int result = 0;

for(int i=0; i<mas.Length; i++){
    mas[i] = rand.Next(10, 100);
    Console.WriteLine($"Элемент массива под индексом {i} равен {mas[i]}");
}

for(int i=0; i<mas.Length; i += 2){
    result += mas[i+1];
}

Console.WriteLine($"\nСумма элементов массива, стоящих на нечетных позициях: {result}");