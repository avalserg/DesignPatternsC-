var builder = new CarBuilder();
BuildRedHondaNow(builder);
var car = builder.Build();
Console.WriteLine($"{car.Make} {car.Colour} {car.ManifactureDate}");
void BuildRedHondaNow(ICarBuilder carBuilder)
{
    carBuilder
        .SetMake("Honda")
        .SetColour("Red")
        .SetManifactureDate(DateTime.UtcNow);
}
public class Car
{
    public string Make { get; set; }
    public string Colour { get; set; }
    public string ManifactureDate { get; set; }
}

public interface ICarBuilder
{
    public ICarBuilder SetMake(string make);

    public ICarBuilder SetColour(string colour);

    public ICarBuilder SetManifactureDate(DateTime date);
}

public class CarBuilder : ICarBuilder
{
    private Car _car = new Car();

    public ICarBuilder SetMake(string make)
    {
        _car.Make = make;
        return this;
    }

    public ICarBuilder SetColour(string colour)
    {
        _car.Colour = colour;
        return this;
    }

    public ICarBuilder SetManifactureDate(DateTime date)
    {
        _car.ManifactureDate = date.ToString("dd/MM/yyyy");
        return this;
    }

    public Car Build() => _car;
}