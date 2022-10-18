class Result
{
    public static int sockMerchant(int n, List<int> ar)
    {
        var pairedSocks = 0;
        var sockTracker = new HashSet<int>();
        for (int i = 0; i < ar.Count; i++)
        {
            if (!sockTracker.Contains(ar[i]))
            {
                sockTracker.Add(ar[i]);
                continue;
            }
            pairedSocks++;
            sockTracker.Remove(ar[i]);
        }
        return pairedSocks;
    }
}