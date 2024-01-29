// See https://aka.ms/new-console-template for more information
using GameForKS;
Console.WriteLine("Угадай число");
Console.WriteLine("Введите Ваше имя:");
string name = Console.ReadLine();
Console.WriteLine("Укажите ваш статус:");
string description = Console.ReadLine();

GameService  game = new GameService(name , description, 0 , 50 );

while (true)
{
    Console.WriteLine("Введите число");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(  game.RaundGo(x));
}