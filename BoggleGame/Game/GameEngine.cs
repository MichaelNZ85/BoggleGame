namespace BoggleGame.Game
{


    public class GameEngine
    {
        private List<string[]> diceValues;
        private Die[] dice;
        private Random random;

        public GameEngine()
        {
            dice = new Die[16];
            random = new Random();
            diceValues = new List<string[]>();

            diceValues.Add(new string[] { "D", "W", "S", "N", "E", "O" });
            diceValues.Add(new string[] { "W", "R", "L", "G", "I", "U" });
            diceValues.Add(new string[] { "C", "L", "A", "R", "E", "S" });
            diceValues.Add(new string[] { "S", "H", "R", "M", "A", "O" });
            diceValues.Add(new string[] { "B", "A", "J", "O", "Q", "M" });
            diceValues.Add(new string[] { "G", "L", "Y", "U", "E", "K" });
            diceValues.Add(new string[] { "C", "O", "A", "T", "I", "A" });
            diceValues.Add(new string[] { "P", "U", "E", "T", "L", "S" });
            diceValues.Add(new string[] { "P", "C", "M", "D", "A", "E" });
            diceValues.Add(new string[] { "G", "E", "T", "I", "N", "V" });
            diceValues.Add(new string[] { "P", "I", "E", "S", "H", "N" });
            diceValues.Add(new string[] { "F", "E", "Y", "H", "I", "E" });
            diceValues.Add(new string[] { "F", "I", "O", "B", "R", "X" });
            diceValues.Add(new string[] { "U", "N", "O", "T", "D", "K" });
            diceValues.Add(new string[] { "D", "A", "Z", "N", "E", "V" });
            diceValues.Add(new string[] { "I", "B", "A", "L", "T", "Y" });

            diceValues = diceValues.OrderBy(_ => random.Next()).ToList();

            for (int i = 0; i < dice.Length; i++) {
                Die theDie = new Die(diceValues[i]);
                dice[i] = theDie;
            }


        }

        public List<string> getDiceValues()
        {
            List<string> diceValues = new List<string>();
            for (int i = 0; i < dice.Length; i++) {
                diceValues.Add(dice[i].getLetter());
            }

            return diceValues;
            //string[,] letters = new string[4, 4];
            /*List<string[]> letters = new List<string[]>();
            int index = 0;
            for (int i = 0; i < 4; i++) {
                string[] letterz = new string[4];
                for (int j = 0; j < 4; j++) {
                    letterz[j] = diceValues[index];
                    //letters[i, j] = diceValues[index];
                    index++;
                }
                letters.Add(letterz);
            }*/


        }


    }
}
