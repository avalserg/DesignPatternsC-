new NavigationBar(new Apple()); //render specifically for some case 
new DropdownMenu(new Android());

public class NavigationBar
{
    public NavigationBar(IUIFactory factory) => factory.CreateButton(); // we can use classes which implement interface
}

public class DropdownMenu
{
    public DropdownMenu(IUIFactory factory) => factory.CreateButton(); // we only use Apple
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
