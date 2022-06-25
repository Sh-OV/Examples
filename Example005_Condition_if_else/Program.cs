Console.Write("Введите своё имя: ");
string user_name = Console.ReadLine();
if (user_name.ToLower() == "маша")
    {
        Console.WriteLine("Ура!!! Это же МАША!!!");
    }
else
    {
        Console.WriteLine("Привет, " + user_name);
    }