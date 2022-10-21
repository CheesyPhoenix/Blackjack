namespace Blackjack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello! Would you like to play a game?...A game of blackjack that is...");

            //main loop
            bool running = true;
            while (running)
            {
                Deck deck = new();

                Hand dealer = new();
                Hand player = new();

                dealer.AddCard(deck.DrawCard());
                player.AddCard(deck.DrawCard());
                dealer.AddCard(deck.DrawCard());
                player.AddCard(deck.DrawCard());

                //game loop
                while (true)
                {
                    Console.Clear();

                    Console.WriteLine($"Dealers hand: \n{dealer.OutputHand()}\n");
                    Console.WriteLine($"Your hand: \n{player.OutputHand()}\n");
                    
                    //check if player lost
                    if (player.Value > 21)
                    {
                        Console.WriteLine($"You Lose! \n");

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                        break;
                    }

                    Console.WriteLine("What do you want to do? 1: Hit, 2: Stand, 3: Leave");
                    string? inp = Console.ReadLine();

                    if (inp == "3" || inp == null)
                    {
                        running = false;
                        break;
                    } else if (inp == "1")
                    {
                        player.AddCard(deck.DrawCard());
                    } else if (inp == "2")
                    {
                        //calculate dealer moves
                        //check for win

                        while (dealer.Value < 17)
                        {
                            dealer.AddCard(deck.DrawCard());
                        }

                        Console.Clear();

                        Console.WriteLine($"Dealers final hand: \n{dealer.OutputHand()}\n");
                        Console.WriteLine($"Your final hand: \n{player.OutputHand()}\n");

                        bool hasWon = false;

                        if (player.Value == 21)
                        {
                            hasWon = true;
                        }
                        else if (player.Value > dealer.Value || dealer.Value > 21)
                        {
                            hasWon = true;
                        }
                        
                        Console.WriteLine($"You {(hasWon ? "Win!" : "Lose")} \n");

                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                        break;
                    }
                }
            }
        }
    }
}