
// nocopy
namespace GameForKS
{
    public class GameService
    {

        private int _raund;  // раунд  ишры
        public int Min { get; private set; } // мин число для загадывания 
        public int Max { get; private set; } // макс  число  

        public Player PlauUs { get; set; } // игрок  человек
        public Player PlauPK { get; set; } // игрок  комп


        public GameService(string name , string description , int  min , int  max) // констуктор  класса 
        {
             PlauUs = new Player (name  , description); 
             PlauPK = new Player ();
             Min = min;
             Max = max;
        }


        public string RaundGo(int numberUser) // 1 раунд  игры
        {
            Random random = new Random();
            int number = random.Next(Min, Max); // искомое  число
            int numberPK = random.Next(Min, Max); // число  пк 
            _raund++; // увеличеть  раунд

            string infoRaund =
               $"Раунд:{_raund}, искомое число: {number}, {PlauPK.Name} ({PlauPK.Description}) загадал: {numberPK}\n"; // инфа о  раунде

            string gameInfo = ""; // результат  игры

            int AbsPk = Math.Abs(number - numberPK);   // модуль  разности  числа 
            int AbsUs = Math.Abs(number - numberUser);

            if (AbsPk == AbsUs) 
                gameInfo = "Ничья";

            if (AbsPk < AbsUs) // победа  компа 
            {
                PlauPK.Points++;
                gameInfo = $"{PlauPK.Name} победил\n";
            }
            else  // победа  юзера 
            {
                PlauUs.Points++;
                gameInfo = $"{PlauUs.Name} победил\n";
            }


                 // раунл 1 ...пк победил                  Вася (пк), счет: 1     петя (юзер) счет: 0  
            return infoRaund + gameInfo + "Итог Игры:\n" + PlauPK.Info() + "\n" + PlauUs.Info(); // итоговый результат  
        }

        public string Info ()
        {
           return  $"Игра \"угодай число\"\n" +
                $"Загадывается случайное число в диапазоне от {Min} до {Max}\n" +
                $"побеждает ток, кто назовет число ближе к загадоному чем соперник";
        }
    }
}
