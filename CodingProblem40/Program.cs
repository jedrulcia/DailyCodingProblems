class Program
{
    static void Main()
    {
        HitCounter hitCounter = new HitCounter();

        hitCounter.Record(1);
        hitCounter.Record(2);
        hitCounter.Record(4);
        hitCounter.Record(5);
        hitCounter.Record(10);

        int lowerTimestamp = 2;
        int upperTimestamp = 5;

        Console.WriteLine($"Total hits between {lowerTimestamp} and {upperTimestamp}: {hitCounter.Range(lowerTimestamp, upperTimestamp)} ");
        Console.WriteLine($"Total hits: {hitCounter.Total()}.");
    }
}

public class HitCounter
{
    private List<int> timestamps;

    public HitCounter()
    {
        timestamps = new List<int>();
    }

    public void Record(int timestamp)
    {
        timestamps.Add(timestamp);
    }
    public int Total()
    {
        return timestamps.Count;
    }
    public int Range(int lower, int upper)
    {
        int count = 0;

        foreach (int timestamp in timestamps)
        {
            if (timestamp >= lower && timestamp <= upper)
            {
                count++;
            }
        }

        return count;
    }
}