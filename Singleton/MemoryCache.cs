class MemoryCache //no lock no sync
{
    private static MemoryCache _instance; //important static modifier

    public MemoryCache()
    {
        Console.WriteLine("Created");

    }

    public static MemoryCache Create()
    {
        return _instance ?? (_instance = new MemoryCache());
    }
}