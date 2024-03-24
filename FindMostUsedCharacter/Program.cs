namespace FindMostUsedCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            string input = "abacddbec";
            FindMostUsedCharacter(input);
        }

        public static void FindMostUsedCharacter(string input)
        {
            Dictionary<char, int> mydic = new Dictionary<char, int>();
            foreach (char character in input)
            {
                if (mydic.ContainsKey(character))
                {
                    mydic[character]++;
                }
                else
                {
                    mydic.Add(character, 1);
                }
            }

            int maxFrequency = mydic.Values.Max();
            foreach (var pair in mydic)
            {
                if (pair.Value == maxFrequency)
                {
                    Console.WriteLine($"가장 많이 사용한 문자: {pair.Key}, 사용된 횟수: {pair.Value}");
                    break;
                }
            }
        }
    }
}
