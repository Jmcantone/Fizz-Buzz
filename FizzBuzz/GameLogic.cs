namespace FizzBuzz
{
    public static class GameLogic
    {
        public static IList<string> GetGameResult(int initialNumber, int lastNumber)
        {
            List<string> result = new();

            for (int i = initialNumber; i < lastNumber + 1; i++)
            {
                var value = GetCorrectValueForNumberPlayed(i);
                result.Add(value);
            }

            return result;
        }

        private static string GetCorrectValueForNumberPlayed(int currentNumber)
        {
            var wordsByNumberMatch = GameConstant.NumberAndWordForReplace
                    .Where(x => (currentNumber % x.Key) == 0)
                    .Select(x => x.Value);

            return wordsByNumberMatch.Any() ? string.Join(" ", wordsByNumberMatch) : currentNumber.ToString();
        }
    }
}
