using System;

public abstract class Pokemon
{
    public enum PokemonType
    {
        Fire,
        Water,
        Grass
    };

    public readonly string name;
    public readonly PokemonType strength;
    public readonly PokemonType weakness;

    public Pokemon(string name, PokemonType strength, PokemonType weakness)
    {
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }

    public abstract string schreeeuwen();

    public bool Beats(Pokemon other)
    {
        return other.strength == this.weakness;
    }

    public string GetName()
    {
        return name;
    }

    public PokemonType GetStrength()
    {
        return strength;
    }

    public PokemonType GetWeakness()
    {
        return weakness;
    }
}

public class Squirtle : Pokemon
{
    public Squirtle() : base("Squirtle", PokemonType.Water, PokemonType.Grass) { }

    public override string schreeeuwen()
    {
        return "Squirtle! Squirtle!";
    }
}

public class Charmander : Pokemon
{
    public Charmander() : base("Charmander", PokemonType.Fire, PokemonType.Water) { }

    public override string schreeeuwen()
    {
        return "Charmander! Charmander!";
    }
}

public class Bulbasaur : Pokemon
{
    public Bulbasaur() : base("Bulbasaur", PokemonType.Grass, PokemonType.Fire) { }

    public override string schreeeuwen()
    {
        return "Bulbasaur! Bulbasaur!";
    }
}
