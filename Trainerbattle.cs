using System;

public class TrainerBattle
{
    public static void Main(string[] args)
    {
        bool keepPlaying = true;

        while (keepPlaying)
        {
            Console.WriteLine("(1) Start the game");
            Console.WriteLine("(2) Quit the game");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Trainer #1's name:");
                string trainerName1 = Console.ReadLine();
                Trainer trainer1 = new Trainer(trainerName1);

                Console.WriteLine($"Trainer #1's name is: {trainerName1}");

                Console.WriteLine("Trainer #2's name:");
                string trainerName2 = Console.ReadLine();
                Trainer trainer2 = new Trainer(trainerName2);

                Console.WriteLine($"Trainer #2's name is: {trainerName2}");

                bool keepBattling = true;

                while (keepBattling)
                {
                    Console.WriteLine("Player 1, choose your Pokémon: Charmander, Bulbasaur, or Squirtle:");
                    Pokemon player1Pokemon = ChoosePokemon();
                    if (player1Pokemon == null) continue;

                    Console.WriteLine("Player 2, choose your Pokémon: Charmander, Bulbasaur, or Squirtle:");
                    Pokemon player2Pokemon = ChoosePokemon();
                    if (player2Pokemon == null) continue;

                    Console.WriteLine(player1Pokemon.schreeeuwen());
                    Console.WriteLine(player2Pokemon.schreeeuwen());

                    if (player1Pokemon.Beats(player2Pokemon))
                    {
                        Console.WriteLine($"{player1Pokemon.GetName()} Beats {player2Pokemon.GetName()}");
                        Console.WriteLine("Player 1 wins!");
                    }
                    else if (player2Pokemon.Beats(player1Pokemon))
                    {
                        Console.WriteLine($"{player2Pokemon.GetName()} Beats {player1Pokemon.GetName()}");
                        Console.WriteLine("Player 2 wins!");
                    }
                    else
                    {
                        Console.WriteLine("It's a tie!");
                    }

                    Console.WriteLine("Do you want to battle again? (yes/no):");
                    string playAgain = Console.ReadLine().ToLower();
                    if (playAgain != "yes")
                    {
                        keepBattling = false;
                    }
                }
            }
            else if (choice == "2")
            {
                keepPlaying = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }

    static Pokemon ChoosePokemon()
    {
        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "charmander":
                return new Charmander();
            case "bulbasaur":
                return new Bulbasaur();
            case "squirtle":
                return new Squirtle();
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return null;
        }
    }
}
