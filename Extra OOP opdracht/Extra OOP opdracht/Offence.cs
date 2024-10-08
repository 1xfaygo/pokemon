using System;
using System.Numerics;

namespace NFL;
public class Offence : Players
{
    public int Catching { get; set; }
    public int Running { get; set; }
    public int Agility { get; set; }

    public Offence(string name,int jerseynumber, string Position, int catching, int running, int agility) : base( name, jerseynumber,Position)
    {
        this.Catching = catching;
        this.Running = running;
        this.Agility = agility;
    }


    public static void Give_Atributes(Offence player)
    {
        Console.WriteLine();
        Console.WriteLine($"{player.Name} has been given the Following atributes");
        Console.WriteLine();
        Console.WriteLine($"Catching rating: {player.Catching}");
        Console.WriteLine();
        Console.WriteLine($"Running rating: {player.Running}");
        Console.WriteLine();
        Console.WriteLine($"Agility rating: {player.Agility}");
        Console.WriteLine();
        Console.WriteLine();
    }
    public int GetCatching()
    { 
        return Catching; 
    }
    public int GetRunning() 
    {   
        return Running;  
    }
    public int GetAgility() 
    { 
        return Agility; 
    }

    public void Score(Offence player)
    {
        Console.WriteLine($"{player.Name} scored!");
    }

    public void Pass(Offence player)
    {
        Console.WriteLine($"{player.Name} made a pass!");
    }

    public void Run(Offence player)
    {
        Console.WriteLine($"{player.Name} is running with {player.Agility} agility !");
    }
}
