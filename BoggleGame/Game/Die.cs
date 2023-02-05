namespace BoggleGame.Game
{
    public class Die
    {
        private string[] letters;
        private Random random;

        public Die(string[] letters)
        {
            this.letters = letters;
            random = new Random();
        }

        public string getLetter()
        {
            return letters[random.Next(letters.Length)];
        }


    }
}
