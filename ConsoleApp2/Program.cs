using ConsoleApp2;

Cat cat = new("assyrian")
{
    Color = "red"
};
cat.MakeSound();
DomesticCat domesticCat = new("assyrian")
{
    Color = "yellow"
};
domesticCat.MakeSound();
StreetCat streetCat = new("unknown")
{
    Color = "black"
};
streetCat.MakeSound();
Dog dog = new()
{
    Color = "brown"
};
dog.MakeSound();