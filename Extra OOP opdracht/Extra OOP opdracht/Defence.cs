using System;

namespace NFL;
public class Defence : Players
{

    public int Catching { get; set; }
    public int Running { get; set; }
    public int Agility { get; set; }


    public Defence(string name, int jerseynumber, string Position, int catching, int running, int agility) : base(name, jerseynumber, Position) 
    {
        this.Catching = catching;
        this.Running = running;
        this.Agility = agility;
    }

    public void Tackle()
   {
        Console.WriteLine($"{Name} tackelt");
   }

   public void Block()
   {
        Console.WriteLine($"{Name} blockt");
   }
    
   public void Intercept()
   {
        Console.WriteLine($"{Name} intercept de bal");

    }
}
