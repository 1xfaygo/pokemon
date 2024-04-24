using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;

public abstract class Pokemon
{
    public string name;
    public string strength;
    public string weakness;

    public Pokemon(string name, string strength, string weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }

    public abstract string schreeeuwen();
}

public class Squirtle : Pokemon
{
    public Squirtle(string name, string strength, string weakness) : base(name, strength, weakness) { }

    public override string schreeeuwen()
    {
        return "Squirtle! Squirtle!";
    }
}

public class Charmander : Pokemon
{
    public Charmander(string name, string strength, string weakness) : base(name, strength, weakness) { }

    public override string schreeeuwen()
    {
        return "Charmander! Charmander!";
    }
}

public class Bulbasaur : Pokemon
{
    public Bulbasaur(string name, string strength, string weakness) : base(name, strength, weakness) { }

    public override string schreeeuwen()
    {
        return "Bulbasaur! Bulbasaur!";
    }
}

public class Pokeball
{
    private Pokemon pokemon;
    private bool hasPokemonInside = false;

    public Pokeball(Pokemon pokemon)
    {
        this.pokemon = pokemon;
    }

    public Pokemon Open()
    {
        hasPokemonInside = true;
        return pokemon;
    }

    public void Close()
    {
        if (hasPokemonInside)
        {
            hasPokemonInside = false;
            Console.WriteLine("Pokeball is closed.");
        }
        else
        {
            Console.WriteLine("Pokeball is already empty.");
        }
    }

    public bool HasPokemonInside()
    {
        return hasPokemonInside;
    }
}

public class Trainer
{
    public string Name { get; }
    public List<Pokeball> Belt { get; }

    public Trainer(string name)
    {
        Name = name;
        Belt = new List<Pokeball>();
    }

    public Pokemon ThrowPokeball()
    {
        if (Belt.Count == 0)
        {
            Console.WriteLine("Trainer's belt is empty");
            return null;
        }

        Pokeball pokeball = Belt[Belt.Count - 1];
        Belt.RemoveAt(Belt.Count - 1);
        Pokemon pokemon = pokeball.Open();
        Console.WriteLine(pokemon.schreeeuwen());
        return pokemon;
    }

    public void TakePokeball(Pokeball pokeball)
    {
        if (Belt.Count >= 6)
        {
            Console.WriteLine("Trainer's belt is full");
            return;
        }

        Belt.Add(pokeball);
    }

    public void ReturnPokemon(Pokemon pokemon)
    {
        if (Belt.Count >= 6)
        {
            Console.WriteLine("Trainer's belt is full");
            return;
        }

        Pokeball pokeball = new Pokeball(pokemon);
        pokeball.Close();
        Belt.Add(pokeball);
    }
}

public class TrainerBattle
{
    public static void Main(string[] args)
    {
        while (true)
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

                Charmander charmander = new Charmander("Charmander", "Fire", "Water");
                Console.WriteLine(charmander.schreeeuwen());
                Squirtle squirtle = new Squirtle("Squirtle", "Water", "Grass");
                Console.WriteLine(squirtle.schreeeuwen());
                Bulbasaur bulbasaur = new Bulbasaur("Bulbasaur", "Grass", "Fire");
                Console.WriteLine(bulbasaur.schreeeuwen());

                Console.WriteLine("_____________________________________________________________________________________");
                
                Charmander charmander1 = new Charmander("Charmander", "Fire", "Water");
                Console.WriteLine(charmander1.schreeeuwen());
                Squirtle squirtle1 = new Squirtle("Squirtle", "Water", "Grass");
                Console.WriteLine(squirtle1.schreeeuwen());
                Bulbasaur bulbasaur1 = new Bulbasaur("Bulbasaur", "Grass", "Fire");
                Console.WriteLine(bulbasaur1.schreeeuwen());


            }
            else if (choice == "2")
            {
                break;
            }
        }
    }
}
