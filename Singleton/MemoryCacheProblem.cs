class MemoryCacheProblem //no lock no sync
{
    private static MemoryCacheProblem _instance; //important static modifier
    private static int i = 0;

    public MemoryCacheProblem()
    {
        Console.WriteLine($"Created {i++}");

    }

    public static MemoryCacheProblem Create()
    {
        return _instance ?? (_instance = new MemoryCacheProblem());
    }
}