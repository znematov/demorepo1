DemoClass demo = new();
demo.DemoMethod();

Console.WriteLine("Hello, World!");


class DemoClass
{
    private string? _testField;

    public string Type { get; set; } = string.Empty;

    public string DemoMethod()
    {
        return "Demo";
    }
}