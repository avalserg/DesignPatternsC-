var commonNavBar = new NavigationBar();
var androidNavBar = new AndroidNavigationBar();
androidNavBar.Render();
commonNavBar.Render();
public abstract class Element
{
    protected Button Button { get; private set; }

    protected void Initialize()
    {
        Button = CreateButton();
    }

    protected abstract Button CreateButton();
    public void Render()
    {
        Console.WriteLine($"Rendering {Button.Type}");
    }

}
public class NavigationBar : Element
{
    public NavigationBar()
    {
        Initialize();
    }

    protected override Button CreateButton()
    {
        return new Button { Type = "DefaultButton" };
    }
}

public class DropdownMenu : Element
{
    public DropdownMenu()
    {
        Initialize();
    }

    protected override Button CreateButton()
    {
        return new Button { Type = "DefaultButton" };
    }
}
public class AndroidNavigationBar : Element
{
    public AndroidNavigationBar()
    {
        Initialize();
    }

    protected override Button CreateButton()
    {
        return new Button { Type = "Android DefaultButton" };
    }
}

public class AndroidDropdownMenu : Element
{
    public AndroidDropdownMenu()
    {
        Initialize();
    }

    protected override Button CreateButton()
    {
        return new Button { Type = "Android DefaultButton" };
    }
}

public class Button
{
    public string Type { get; set; }
}