namespace FizzBuzz
{
    public static class Exporter
    {
        public static void PrintToConsole(List<string> gameResult)
        {
            gameResult.ForEach(x => Console.WriteLine(x));
        }
    }
}
