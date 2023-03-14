using System;
using ConsoleCards;

namespace ProgrammingAssignment3
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 3
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK
				Deck deck = new Deck();

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
				Card player1FirstCard = deck.TakeTopCard();
				Card player2FirstCard = deck.TakeTopCard();
				Card player3FirstCard = deck.TakeTopCard();
				Card player4FirstCard = deck.TakeTopCard();

				Card player1SecondCard = deck.TakeTopCard();
				Card player2SecondCard = deck.TakeTopCard();
				Card player3SecondCard = deck.TakeTopCard();
				Card player4SecondCard = deck.TakeTopCard();

                // deal 1 more card to players 2 and 3
				Card player2ThirdCard = deck.TakeTopCard();
				Card player3ThirdCard = deck.TakeTopCard();

                // flip all the cards over
				player1FirstCard.FlipOver();
				player1SecondCard.FlipOver();

				player2FirstCard.FlipOver();
				player2SecondCard.FlipOver();
				player2ThirdCard.FlipOver();

				player3FirstCard.FlipOver();
				player3SecondCard.FlipOver();
				player3ThirdCard.FlipOver();

				player4FirstCard.FlipOver();
				player4SecondCard.FlipOver();

                // print the cards for player 1
				Console.WriteLine($"{player1FirstCard.Rank},{player1FirstCard.Suit}");
				Console.WriteLine($"{player1SecondCard.Rank},{player1SecondCard.Suit}");

                // print the cards for player 2
				Console.WriteLine($"{player2FirstCard.Rank},{player2FirstCard.Suit}");
				Console.WriteLine($"{player2SecondCard.Rank},{player2SecondCard.Suit}");
				Console.WriteLine($"{player2ThirdCard.Rank},{player2ThirdCard.Suit}");


                // print the cards for player 3
				Console.WriteLine($"{player3FirstCard.Rank},{player3FirstCard.Suit}");
				Console.WriteLine($"{player3SecondCard.Rank},{player3SecondCard.Suit}");
				Console.WriteLine($"{player3ThirdCard.Rank},{player3ThirdCard.Suit}");


                // print the cards for player 4
				Console.WriteLine($"{player4FirstCard.Rank},{player4FirstCard.Suit}");
				Console.WriteLine($"{player4SecondCard.Rank},{player4SecondCard.Suit}");


                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
