class MemoryCacheProblemBadSolution // + static ctor
{
    private static MemoryCacheProblemBadSolution _instance; //important static modifier
    private static int i = 0;
    static MemoryCacheProblemBadSolution()
    {
        _instance = new MemoryCacheProblemBadSolution();

    }
    public MemoryCacheProblemBadSolution()
    {
        Console.WriteLine($"Created {i++}");

    }

    public static MemoryCacheProblemBadSolution Create()
    {
        return _instance;
    }
}