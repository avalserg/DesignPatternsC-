class MemoryCacheProblemSolution // + static ctor
{
    private static MemoryCacheProblemSolution _instance; //important static modifier
    private static int i = 0;
    private static object _cacheLock = new object();
   
    public MemoryCacheProblemSolution()
    {
        Console.WriteLine($"Created {i++}");

    }

    public static MemoryCacheProblemSolution Create()
    {
        if (_instance == null)
        {
            lock (_cacheLock)
            {
                if (_instance == null)
                {
                    return _instance = new MemoryCacheProblemSolution();
                }
            }
        }
        return _instance;
    }
}