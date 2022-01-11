namespace FizzBuzz
{
    public static class GameConstant
    {
        public readonly static int IntialNumber = 1;
        public readonly static int LastNumber = 100;

        public readonly static Dictionary<int, string> NumberAndWordForReplace = new()
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };
    }
}
