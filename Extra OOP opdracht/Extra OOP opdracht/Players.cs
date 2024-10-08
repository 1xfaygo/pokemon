using System;
using System.Runtime.CompilerServices;

namespace NFL;
public class Players
{
    // these are the variables
    public string Name;
    public int Jerseynumber;
    public string Position;

    // this is a constructor 
    public Players(string name, int jerseynumber, string Position)
    {
        this.Name = name; 
        this.Jerseynumber = jerseynumber; 
        this.Position = Position;
     }

    // this method returns the name 
    public string GetName()
    {
        return Name;
    }
    
    // this method returns every objects that this class has
    public override string ToString()
    {
        return $"Name: {Name}, Position: {Position}, Jersey Number: {Jerseynumber}"; 
    }

}
