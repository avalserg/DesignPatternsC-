Client client = new Client();

var simple = new ConcreteComponent();
Console.WriteLine("Client: I get a simple component:");
client.ClientCode(simple);
Console.WriteLine();

ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
//ConcreteDecoratorA decorator3 = new ConcreteDecoratorA(decorator2);
Console.WriteLine("Client: Now I've got a decorated component:");
client.ClientCode(decorator2);

public abstract class Component //common base type
{
    public abstract string Operation();
}

class ConcreteComponent : Component
{
    public override string Operation()
    {
        return "ConcreteComponent";
    }
}

abstract class Decorator : Component
{
    protected Component _component;

    public Decorator(Component component)
    {
        _component = component;
    }

    public void SetComponent(Component component)
    {
        _component = component;
    }

    public override string Operation()
    {
        if (_component != null)
        {
            return _component.Operation();
        }
        else
        {
            return string.Empty;
        }
    }
}

class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component comp) : base(comp)
    {
    }

    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}

class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(Component comp) : base(comp)
    {
    }

    public override string Operation()
    {
        return $"ConcreteDecoratorB({base.Operation()})";
    }
}

public class Client
{

    public void ClientCode(Component component)
    {
        Console.WriteLine("RESULT: " + component.Operation());
    }
}