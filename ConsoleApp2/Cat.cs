namespace ConsoleApp2;

public class Cat : Animal
{
    public Cat(string breed)
    {
        Breed = breed;
    }

    public string Breed { get; private set; }
    
    public void Lay() { }

    public void AskForFood() { }

    public void Run() { }
    public override string MakeSound()
    {
        return "Meow";
    }
}