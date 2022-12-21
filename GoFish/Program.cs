namespace GoFish
{
    internal class Program
    {
        /// <summary>
        /// Play a game of Go Fish!
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// The GameController to manage the game
        /// </summary>
        static GameController gameController;

        /// <summary>
        /// Prompt the human player for a card value
        /// in their hand
        /// </summary>
        /// <returns>The value to ask for</returns>
        static Values PromptForAValue()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prompt the human player for an opponent
        /// to ask for a card
        /// </summary>
        /// <returns>The opponent to ask</returns>
        static Player PromptForAnOpponent()
        {
            throw new NotImplementedException();
        }
    }
}