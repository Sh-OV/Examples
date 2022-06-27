// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
int [] array = {14, 15, 67, 89, 45, 34, 12, 98, 34, 78, 90};
int find = new Random().Next(0, 15);
Console.WriteLine($"find = {find}");
int index = 0;
while (index < 11)
{
    if (index == find)
    {
        Console.WriteLine($"В элементе массива {find} хранится число {array[index]}");
        return;
    }
    else if (index != find) 
    {
        index++;
    }
}
Console.WriteLine("Алгоритм завершил работу безуспешно!");
