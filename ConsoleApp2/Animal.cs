namespace ConsoleApp2;

public abstract class Animal
{
    public virtual string MakeSound()
    {
        return "Animals sound";
    }
    
    public string Color { get; set; }
}