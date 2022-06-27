// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
/*
Console.WriteLine("РЕШЕНИЕ по поиску номера заданного индекса и выводом значения элемнта этого индекса");
int [] array = {14, 15, 67, 89, 45, 34, 12, 98, 34, 78, 90};
int n = array.Length;
int find = new Random().Next(0, (n +3));
Console.WriteLine($"find = {find}");
int index = 0;
while (index < n)
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
*/
Console.WriteLine("РЕШЕНИЕ по поиску элемента массива и выводу его номера");
int [] array = {14, 15, 67, 89, 45, 34, 12, 98, 34, 78, 90};
int n = array.Length;
Console.Write("Введите любое число: ");
int find = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Вы угадали, в массиве есть число {find}, оно находится под номером {index}");
        return;
    }
     else if (array[index] != find) 
    {
        index++;
    }
}
Console.WriteLine($"Вам не повезло - Вашего числа {find} нет в массиве! Алгоритм завершил работу безуспешно!");

