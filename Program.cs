using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {

            // created 2 lists that hold the cards 2 different values
            var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King" };
            var suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };

            // blank list to use later
            var deck = new List<string>();

            // can also use foreach statements here instead of the for
            foreach (var rank in ranks)
            {
                foreach (var suit in suits)
                {
                    var fulNumber = $"{rank} of {suit}";
                    deck.Add(fulNumber);

                }
            }

            // statement to display
            foreach (var num in deck)
            {
                Console.WriteLine($"{num}");
            }
            Console.WriteLine("--------------------------------");
            // need to shuffle the cards
            var numberOfCards = deck.Count;
            //  for rightIndex from numberOfCards - 1 down to 1 do:
            // leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer"
            for (var end = numberOfCards - 1; end >= 0; end--)
            {
                var somePlace = new Random().Next(0, end);
                var copiedCard = deck[end];
                deck[end] = deck[somePlace];
                deck[somePlace] = copiedCard;
            }
            foreach (var num in deck)
            {
                Console.WriteLine($"{num}");
            }

            Console.WriteLine($"My two random cards are {deck[0]} and {deck[1]}");
        }
    }
}
