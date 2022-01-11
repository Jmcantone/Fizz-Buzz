namespace FizzBuzz
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Fizz Buzz Game\n");
            Console.WriteLine($"Playing from {GameConstant.IntialNumber} to {GameConstant.LastNumber}...\n");

            var result = GameLogic
                .GetGameResult(GameConstant.IntialNumber, GameConstant.LastNumber)
                .ToList();

            Exporter.PrintToConsole(result);
        }
    }
}