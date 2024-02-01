// track
using GameForKS;
Console.WriteLine("Игра \"Угадай число\"");
Console.WriteLine("Введите Ваше имя:");
string name = Console.ReadLine();
Console.WriteLine("Укажите ваш статус:");
string description = Console.ReadLine();

GameService  game = new GameService(name , description, 0 , 50 );

Console.WriteLine("_________");
Console.WriteLine(game.Info());
Console.WriteLine("_________");

while (true) // каждый раунд 
{
    Console.WriteLine("Введите число:");
    
    string  s  = Console.ReadLine(); 
    int  x = 0;

    try { x = Convert.ToInt32(s); } //  проверка 
    catch
    {
        Console.WriteLine("не число");
        continue;  // прерывает  команды дальше  
    }

    Console.WriteLine("_________");
    Console.WriteLine(game.RaundGo(x));
    Console.WriteLine("_________");

    Console.WriteLine("Сыграем еще?");
  

}