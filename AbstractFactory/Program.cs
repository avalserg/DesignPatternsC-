new NavigationBar(new Apple()); //render specifically for some case 
new DropdownMenu(new Apple());

public class NavigationBar
{
    public NavigationBar(Apple factory) => factory.CreateButton(); // we only use Apple
}

public class DropdownMenu
{
    public DropdownMenu(Apple factory) => factory.CreateButton(); // we only use Apple
}

public interface IUIFactory
{
    public Button CreateButton();
}

public class Apple : IUIFactory
{
    public Button CreateButton()
    {
        return new Button()
        {
            Type = "iOS Button"
        };
    }
}
public class Android : IUIFactory
{
    public Button CreateButton()
    {
        return new Button()
        {
            Type = "Android Button"
        };
    }
}
public class Button
{
    public string Type { get; set; }
}
