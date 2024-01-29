

namespace GameForKS
{
    internal class GameService
    {

        private int _raund; 

        public int Min { get; private set; }
        public int Max { get; private set; }

        public Player PlauUs { get; set; }
        public Player PlauPK { get; set; }

        public GameService(string name , string description , int  min , int  max)
        {
             PlauUs = new Player (name  , description);
             PlauPK = new Player ();
             Min = min;
             Max = max;
        }


        public string RaundGo(int numberUser)
        {
            Random random = new Random();
            int number = random.Next(Min, Max); // искомое  число
            int numberPK = random.Next(Min, Max); // число  пк 
            _raund++;

            string infoRaund =
               $"Раунд:{_raund}, искомое число: {number}, {PlauPK.Name} ({PlauPK.Description}) загадал:{numberPK}\n"; // инфа о  раунде

            string gameInfo = ""; // результат  игры

            if (Math.Abs(number - numberPK) == Math.Abs(number - numberUser))
                gameInfo = "Ничья";

            if (Math.Abs(number - numberPK) < Math.Abs(number - numberUser))
            {
                PlauPK.Score++;
                gameInfo = $"{PlauPK.Name} победил\n";
            }
            else
            {
                PlauUs.Score++;
                gameInfo = $"{PlauUs.Name} победил\n";
            }

            return infoRaund + gameInfo + "Итог Игры:\n" + PlauPK.Info() + "\n" + PlauUs.Info(); // итоговый результат  
        }
    }
}
