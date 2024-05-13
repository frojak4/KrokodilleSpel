namespace KrokodilleSpel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameState = true;
            Random random = new Random();
            int number1 = 0;
            int number2 = 0;
            int score = 0;
            while (gameState) { 
                Console.Clear();
                Console.WriteLine($"Your score is: {score}");
                number1 = random.Next(1, 11);
                number2 = random.Next(1, 11);
                Console.WriteLine($"{number1}_{number2}");
                string playerGuess = Console.ReadLine();

                if (number1 > number2 && playerGuess == ">")
                {
                    score += 1;
                } else if (number1 < number2 && playerGuess == "<")
                {
                    score += 1;
                } else if (number1 == number2 && playerGuess == "=")
                {
                    score += 1;
                }
                else if (playerGuess != ">" && playerGuess != "<" && playerGuess != "=")
                {
                    gameState = false;
                    Console.Clear();
                    Console.WriteLine($"Thanks for playing! Your final score is {score}");
                }
                else
                {
                    score -= 1;
                }
            }
        }
    }
}
