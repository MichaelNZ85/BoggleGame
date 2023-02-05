using System.Diagnostics;
using System.Windows.Input;

namespace BoggleGame.Game
{
    public class GameViewModel
    {
        public List<string> Letters { get; set; }
        public ICommand RollDice { get; }
        GameEngine game;

        public GameViewModel()
        {
            game = new GameEngine();
            RollDice = new Command(() => RollTheDice());
        }

        private void RollTheDice()
        {
            Letters = game.getDiceValues();
            Debug.WriteLine(Letters);
        }
    }
}
