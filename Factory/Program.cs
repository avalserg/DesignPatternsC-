new NavigationBar();
new DropdownMenu();

public class NavigationBar
{
    public NavigationBar() => ButtonFactory.CreateButton();
}

public class DropdownMenu
{
    public DropdownMenu() => ButtonFactory.CreateButton();
}

public class ButtonFactory
{
    public static Button CreateButton()
    {
        return new Button()
        {
            Type = "RedButton" // rename to RedButton in one place
        };
    }
}
public class Button
{
    public string Type { get; set; }
}