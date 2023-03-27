namespace Portfolio
{
    internal class Program
    {
        static void Main(string[] args)
        {
        {
            int[] numbers = { 3, 2, 3, 1, 2, 4, 4, 4, 5, 5 };
            int mostFrequentNumber = FindMostFrequentNumber(numbers);
            Console.WriteLine(mostFrequentNumber);
        }
        static int FindMostFrequentNumber(int[] numbers)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }
            int maxCount = 0;
            int mostFrequentNumber = 0;
            foreach (int number in counts.Keys)
            {
                if (counts[number] > maxCount)
                {
                    maxCount = counts[number];
                    mostFrequentNumber = number;
                }
            }
            return mostFrequentNumber;
        }
    }
}