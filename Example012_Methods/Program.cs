/*Работа с текстом
Дан текст. В тексте нужно:
1. Все пробелы заменить черточками;
2. маленькие буквы "к" заменть большими "К";
3. Большими "С" заменить маленькие "с".*/
Console.Clear();
string text = "- Я думаю, - сказал князь, улыбаясь, - что, " 
            + "ежели бы вас послаливместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace (string txt, char oldSimbol, char newSimbol)
{
    string result = String.Empty;
    int length = txt.Length;
    for (int i = 0; i < length; i++)
    {
        if (txt[i] == oldSimbol)  result = result + $"{newSimbol}";
        else result = result + $"{txt[i]}";
    }
    return result;
}
 string newText1 = Replace(text, ' ', '|');
string newText2 = Replace(newText1, 'к', 'К');
string newText3 = Replace(newText2, 'с', 'С');
Console.WriteLine(newText3);

// Console.WriteLine();
// string Replace2 (string txt, char oldSimbol1, char newSimbol1, 
//                              char oldSimbol2, char newSimbol2, 
//                              char oldSimbol3, char newSimbol3)
// {
//     string result = String.Empty;
//     int length = txt.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (txt[i] == oldSimbol1)  result = result + $"{newSimbol1}";
//         else if (txt[i] == oldSimbol2)  result = result + $"{newSimbol2}";
//         else if (txt[i] == oldSimbol3)  result = result + $"{newSimbol3}";
//         else result = result + $"{txt[i]}";
//     }
//     return result;
// }
// string newText4 = Replace2(text, ' ', '|', 'к', 'К', 'с', 'С');
// Console.WriteLine(newText4);


// Сортировка массива:
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray (int [] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;  

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }


        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
