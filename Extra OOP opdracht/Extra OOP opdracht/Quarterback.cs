using System;

namespace NFL;
public class Quarterback : Players
{

    public int Throwing { get; set; }
    public int Running { get; set; }
    public int FootballIQ { get; set; }





    public Quarterback(string name, int jerseynumber, string Position, int throwing, int running, int footballiq) : base(name, jerseynumber,Position)
    {
        this.Throwing = throwing;
        this.Running = running;
        this.FootballIQ = footballiq;
    }
    public void Throw()
	{
        Console.WriteLine($"{Name} gooit de bal");
    }
	
	public void Run()
	{
        Console.WriteLine($"{Name} rent met de bal");
    }
	
	public void Score()
	{
        Console.WriteLine($"{Name} scoort");
    }
}
