using System;
using System.Collections.Generic;

public sealed class Pokeball
{
    private readonly Pokemon pokemon;
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
    private readonly string name;
    private readonly List<Pokeball> pokeballs;
    private const int MaxPokeballs = 6;

    public Trainer(string name)
    {
        this.name = name;
        this.pokeballs = new List<Pokeball>();
    }

    public string GetName()
    {
        return name;
    }

    public IReadOnlyList<Pokeball> GetPokeballs()
    {
        return pokeballs.AsReadOnly();
    }

    public bool AddPokeball(Pokeball pokeball)
    {
        if (pokeballs.Count < MaxPokeballs)
        {
            pokeballs.Add(pokeball);
            return true;
        }
        return false;
    }

    public Pokemon ThrowPokeball()
    {
        if (pokeballs.Count == 0)
        {
            Console.WriteLine("Trainer's belt is empty");
            return null;
        }

        Pokeball pokeball = pokeballs[pokeballs.Count - 1];
        pokeballs.RemoveAt(pokeballs.Count - 1);
        Pokemon pokemon = pokeball.Open();
        Console.WriteLine(pokemon.schreeeuwen());
        return pokemon;
    }

    public void TakePokeball(Pokeball pokeball)
    {
        if (pokeballs.Count >= 6)
        {
            Console.WriteLine("Trainer's belt is full");
            return;
        }

        pokeballs.Add(pokeball);
    }

    public void ReturnPokemon(Pokemon pokemon)
    {
        if (pokeballs.Count >= 6)
        {
            Console.WriteLine("Trainer's belt is full");
            return;
        }

        Pokeball pokeball = new Pokeball(pokemon);
        pokeball.Close();
        pokeballs.Add(pokeball);
    }
}
