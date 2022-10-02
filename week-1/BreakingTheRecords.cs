class Result
{
    public static List<int> breakingRecords(List<int> scores)
    {
        var min = scores[0];
        var minCount = 0;
        var max = scores[0];
        var maxCount = 0;

        for (int i = 0; i < scores.Count; i++)
        {
            if (scores[i] < min)
            {
                min = scores[i];
                minCount++;
            }
            if (scores[i] > max)
            {
                max = scores[i];
                maxCount++;
            }
        }
        return new List<int> { maxCount, minCount };
    }
}