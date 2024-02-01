
namespace GameForKS
{
    // nocopy
    public class Player
    {
        public string Name {  get; private set; }   // имя
        public string Description { get; set; } // описание , статус 
        public int Points { get;  set; } // очки

        public Player () // если копм.
        {
            Name = "Вася";
            Points = 0;
            Description = "ПК";
        }

        public Player(string name  , string description) // если человек
        {
            Name = name;
            Points = 0;
            Description = description;
        }

        public string Info () 
        {
                   //"Вася  (предсказатель), cчет:  10 "
            return $"{Name} ({Description}), cчет: {Points}";
        }

    }
}
