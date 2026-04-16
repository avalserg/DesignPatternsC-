new Tea(new Sugar()).PrepareTea();
new Tea(new Milk()).PrepareTea();

class Tea
{
    private readonly IIngredient _ingredient;
    public Tea(IIngredient ingredient)
    {
        _ingredient = ingredient;
    }
    public void PrepareTea()
    {
        BoilWater();
        BrewTea();
        _ingredient.PutIngredient();
        Serve();
    }

    private void BoilWater() => Console.WriteLine("Boil water");
    private void BrewTea() => Console.WriteLine("Brew tea");
    private void Serve() => Console.WriteLine("Serve tea");
}
interface IIngredient
{
    void PutIngredient();
}

class Sugar : IIngredient
{
    public void PutIngredient()
    {
        Console.WriteLine("Put Sugar");
    }
}

class Milk : IIngredient
{
    public void PutIngredient()
    {
        Console.WriteLine("Put Milk");
    }
}