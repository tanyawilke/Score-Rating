using System;

namespace scorerating
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 1, 2, 3 };
            int[] scores = { 3, 2, 1 };
            int money = 3;

            Console.WriteLine(AskForRating(prices, scores, money));
            Console.ReadLine();
        }

        static int AskForRating(int[] prices, int[] scores, int money)
        {
            // customer has money available
            // we have articles with prices
            // customer with every article gets a score
            // max sum of scores so corresponsing some of prices doesn't exceed money
            var score = 0;
            var price = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                price += prices[i];                

                if (price <= money)
                {
                    score += scores[i];
                }
            }

            return score;
        }
    }
}
