using System.Globalization;

namespace ConsoleApp2;

public class DomesticCat : Cat
{
    public DomesticCat(string breed) : base(breed) { }

    public string Lakab { get; set; }
    public string Owner { get; set; }
}