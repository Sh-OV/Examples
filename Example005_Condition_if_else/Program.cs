Console.Write("Введите своё имя: ");
var user_name = Console.ReadLine();
if (user_name != null && user_name.ToLower() == "маша")
    {
        Console.WriteLine("Ура!!! Это же МАША!!!");
    }
else
    {
        Console.WriteLine("Привет, " + user_name);
    }