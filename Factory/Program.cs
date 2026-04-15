new NavigationBar();
new DropdownMenu();

//Bad Example
//We need to change Type in several places
//if some logic changes
public class NavigationBar
{
    public NavigationBar() =>
        new Button()
        {
            Type = "DefaultButton" // rename to RedButton
        };

}

public class DropdownMenu
{
    public DropdownMenu() =>
        new Button()
        {
            Type = "DefaultButton" // rename to RedButton
        };
}

public class ButtonFactory
{
    public static Button CreateButton()
    {
        return null;
    }
}
public class Button
{
    public string Type { get; set; }
}