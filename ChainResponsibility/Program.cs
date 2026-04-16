var ide = new IDE(null);
var editor = new CodeEditor(ide);
var codeSelection = new CodeSelection(editor);

codeSelection.HandleKey("Ctrl+F");
codeSelection.HandleKey("Alt+F4");


interface IKeyHandler
{
    void HandleKey(string key);
}

class IDE : IKeyHandler
{
    IKeyHandler _handler;

    public IDE(IKeyHandler handler) => _handler = handler;

    public void HandleKey(string key)
    {
        if (key == "Ctrl+F")
        {
            Console.WriteLine("Full Search");
        }
        else if (key == "Alt+F4")
        {
            Console.WriteLine("Close Application?");
        }
        else
        {
            _handler?.HandleKey(key);
        }
    }
}

class CodeEditor : IKeyHandler
{
    IKeyHandler _handler;

    public CodeEditor(IKeyHandler handler) => _handler = handler;

    public void HandleKey(string key)
    {
        if (key == "Ctrl+F")
        {
            Console.WriteLine("Local Search");
        }
        else
        {
            _handler?.HandleKey(key);
        }
    }
}

class CodeSelection : KeyHandler<CodeEditor> //example with constraint
{
    IKeyHandler _handler;

    public CodeSelection(CodeEditor handler) : base(handler) => _handler = handler;

    public override void HandleKey(string key)
    {
        if (key == "Ctrl+F")
        {
            Console.WriteLine("Selection Search");
        }
        else
        {
            _handler?.HandleKey(key);
        }
    }
}

abstract class KeyHandler<TNext> : IKeyHandler
    where TNext : IKeyHandler
{
    protected readonly TNext Next;

    protected KeyHandler(TNext next)
    {
        Next = next;
    }

    public abstract void HandleKey(string key);
}