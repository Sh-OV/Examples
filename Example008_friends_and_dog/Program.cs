Console.Clear();
int count = 0;
int time = 10;
int distance = 10000;
int first_friend_speed = new Random().Next(1, 4);
Console.WriteLine("Скорость первого друга = " + first_friend_speed);
int second_friend_speed = new Random().Next(1, 4);
Console.WriteLine("Скорость второго друга = " + second_friend_speed);
int dog_speed = new Random().Next(5, 8);
Console.WriteLine("Скорость собаки = " + dog_speed);
int friend = 2;
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (first_friend_speed + dog_speed);
        friend = 2;
//        Console.WriteLine("time1 = " + time);
    }
    else 
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 1;
//        Console.WriteLine("time2 = " + time);
    }
    distance = distance - (first_friend_speed + second_friend_speed) * time;
 //   Console.WriteLine("distance = " + distance);
    count ++;
//    Console.WriteLine("count = " + count);
}
Console.WriteLine($"Собака пробежала {count} раз от одного друга до другого, пока они шли на встречу друг другу");