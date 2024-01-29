
namespace GameForKS
{
    internal class Player
    {
        public string Name {  get; private set; }   
        public string Description { get; set; }
        public int Score { get;  set; }

        public Player ()
        {
            Name = "Вася";
            Score = 0;
            Description = "ПК";
        }

        public Player(string name  , string description)
        {
            Name = name;
            Score = 0;
            Description = description;
        }

        public string Info ()
        {
            return $"{Name} ({Description}), Счет: {Score} ";
        }

    }
}
