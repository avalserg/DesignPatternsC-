
//var cache = MemoryCache.Create();
//Console.WriteLine(cache.GetHashCode());
//var cache2 = MemoryCache.Create();
//Console.WriteLine(cache2.GetHashCode());
//int size = 8;
//Task[] tasks = new Task[size];
//for (int i = 0; i < size; i++)
//{
//    tasks[i] = Task.Run(() => MemoryCacheProblemSolution.Create());
//}

//Task.WaitAll(tasks);

//int size = 10;
//Task[] tasks = new Task[size];
//for (int i = 0; i < size; i++)
//{
//    tasks[i] = Task.Run(() =>
//    {
//        var c = MemoryCacheGood.Create();
//        if (!c.Contains("job_id", "job1")) //multi times call 
//        {
//            Console.WriteLine("Big Operation");
//        }
//    });
//}
//Task.WaitAll(tasks);

int size = 10;
Task[] tasks = new Task[size];
for (int i = 0; i < size; i++)
{
    tasks[i] = Task.Run(() =>
    {
        var c = MemoryCacheGood.Create();
        if (c.AquireKey("job_id", "job1")) //1 time call because of AquireKey logic
        {
            Console.WriteLine("Big Operation");
        }
    });
}
Task.WaitAll(tasks);

public class MemoryCacheGood
{
    private static MemoryCacheGood cache;
    private static object cacheLock = new object();

    private readonly Dictionary<string, string> _registry;

    private MemoryCacheGood() => _registry = new Dictionary<string, string>();

    public static MemoryCacheGood Create()
    {
        if (cache == null)
        {
            lock (cacheLock)
            {
                if (cache == null)
                {
                    return cache = new MemoryCacheGood();
                }
            }
        }

        return cache;
    }

    public bool Contains(string key, string value)
    {
        return _registry.Contains(KeyValuePair.Create(key, value));
    }

    public void Write(string key, string value)
    {
        _registry[key] = value;
    }


    public bool AquireKey(string key, string value)
    {
        lock (cacheLock)
        {
            if (Contains(key, value))
            {
                return false;
            }
            Write(key, value);

            return true;
        }
    }
}