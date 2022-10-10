class Result
{
    public static int lonelyinteger(List<int> a)
    {
        var result = 0;
        for (int i = 0; i < a.Count; i++)
        {
            result ^= a[i];
        }
        return result;
    }
}