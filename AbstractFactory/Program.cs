var navBar = new NavigationBar(new Apple());
var dropdown = new DropdownMenu(new Android());
Console.WriteLine(navBar.Button.Type);
Console.WriteLine(navBar.Checkbox.Type);
Console.WriteLine(dropdown.Button.Type);

public class NavigationBar
{
    public Button Button { get; }
    public Checkbox Checkbox { get; }

    public NavigationBar(IUIFactory factory)
    {
        Button = factory.CreateButton();
        Checkbox = factory.CreateCheckbox();
    }
}

public class DropdownMenu
{
    public Button Button { get; }

    public DropdownMenu(IUIFactory factory)
    {
        Button = factory.CreateButton();
    }
}

public interface IUIFactory
{
    Button CreateButton();
    Checkbox CreateCheckbox();
}

public class Apple : IUIFactory
{
    public Button CreateButton() =>
        new Button { Type = "iOS Button" };

    public Checkbox CreateCheckbox() =>
        new Checkbox { Type = "iOS Checkbox" };
}
public class Android : IUIFactory
{
    public Button CreateButton() =>
        new Button { Type = "Android Button" };
    public Checkbox CreateCheckbox() =>
        new Checkbox { Type = "Android Checkbox" };
}
public class Button
{
    public string Type { get; set; }
}

public class Checkbox
{
    public string Type { get; set; }
}
