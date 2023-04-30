namespace ConsoleApp2;

public class Car
{
    public string Number { get; set; }
    public string Mark { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public Car(string number)
    {
        Number = number;
    }
    public void Krug(){}

    public string Distance(string a, string b)
    {
        return $"From {a} to {b}";
    }
}