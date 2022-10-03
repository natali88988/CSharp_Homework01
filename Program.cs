Console.Write("Введите количество посетителей: ");
int count = Convert.ToInt32(Console.ReadLine());

List<String>[] timeInOut = new List<String>[count];

// заполнение массива списков прихода-ухода каждого покупателя
for (int i=0; i<count; i++){
    Console.Write($"Введите время прихода и ухода посетителя № {i+1} (например, 10-13): ");
   // string s = Console.ReadLine();
    timeInOut[i] = Console.ReadLine().Split('-').ToList();
}

// преобразование списка приход-уход в список с перечислением всех часов нахождения в магазине для каждого покупателя
for (int i=0; i<count; i++){
    int lasting = Convert.ToInt32(timeInOut[i][1]) - Convert.ToInt32(timeInOut[i][0]); // вычисление длительности пребывания в магазине (в часах)
    for (int j=0; j<lasting+1; j++){
        int nextElement = Convert.ToInt32(timeInOut[i][0]) + j;
        timeInOut[i].Add(nextElement.ToString());
    }
    timeInOut[i].RemoveAt(0); // удаление из списка времени прихода
    timeInOut[i].RemoveAt(0); // удаление из списка времени ухода
}

// нахождение объединения всех списков
List<string> result = timeInOut[0];
for (int i=1; i<count; i++){
    result = result.Intersect(timeInOut[i]).ToList();
}
Console.WriteLine($"Больше всего посетителей было в промежуток времени {result[0]} - {result[result.Count - 1]}");
