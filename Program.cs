/*
 * Ankit Bombwal
 * Simulates the card game "War" between two players.
 * A player wins when they have the entirety of the 52-card deck.
 */

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // default values for player names
            string player1 = "";
            string player2 = "";

            // Gathering user inputs for player names.
            Console.WriteLine("Time for WAR!!!");
            Console.WriteLine("What's Player 1's name?");
            player1 = Console.ReadLine();
            Console.WriteLine("What's Player 2's name?");
            player2 = Console.ReadLine();

            // Making sure player one and player two have names for later.
            if (player1 == "") 
            {
                player1 = "John";
            }

            if (player2 == "")
            {
                player2 = "Jane";
            }

            war(player1, player2);
        }

        public static void war(string p1, string p2)
        {
            // initialized number of cards for each player. 
            int p1Cards = 26;
            int p2Cards = 26;

            // round counter
            int counter = 1;

            // initialized varaibles to hold the drawn cards.
            int p1Draw, p2Draw;

            // do-while loop runs at least once before checking values.
            do
            {
                // Drawing cards for the round
                p1Draw = draw();
                p2Draw = draw();

                if(p1Draw > p2Draw) // p1 wins the draw
                {
                    p1Cards++;
                    p2Cards--;

                    Console.WriteLine("{0} won with {1} over {2}.", p1, p1Draw, p2Draw );

                } else if(p2Draw > p1Draw) // p2 wins the draw
                {
                    p2Cards++;
                    p1Cards--;

                    Console.WriteLine("{0} won with {1} over {2}.", p2, p2Draw, p1Draw);

                }
                else // in case of a tie
                {
                    Console.WriteLine("Both players drew the same number, this round is a draw.");
                }
                counter++;
                Console.WriteLine("{0} has {1} cards, {2} has {3} cards.", p1, p1Cards, p2, p2Cards);

            } while (p1Cards > 0 && p2Cards > 0);
            // Game ends when one player has 0 cards remaining.

            // Custom output depending on who won
            if(p1Cards == 0)
            {
                Console.WriteLine("After {0} rounds, {1} won with a score of 52!", counter, p2);
            }
            else
            {
                Console.WriteLine("After {0} rounds, {1} won with a score of 52!", counter, p1);
            }
        }

        // Generates and returns a random integer from 1-13
        // which symbolizes a card value.
        public static int draw()
        {
            Random card = new Random();
            return card.Next(1,14);
        }
    }
}