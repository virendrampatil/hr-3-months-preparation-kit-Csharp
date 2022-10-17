class Result
{
    public static int countingValleys(int steps, string path)
    {
        var count = 0;
        var valley = 0;
        for (int i = 0; i < path.Length; i++)
        {
            count += path[i] == 'U' ? 1 : -1;
            if(count == 0 && path[i] == 'U')
                valley ++;
        }
        return valley;
    }
}