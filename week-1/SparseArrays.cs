class Result
{
    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        var result = new List<int>();
        var numberOfOccurrences= 0;
        for (int i = 0; i < queries.Count; i++)
        {
            for (int j = 0; j < strings.Count; j++)
            {
                if (queries[i] == strings[j])
                    numberOfOccurrences++;
            }
            result.Add(numberOfOccurrences);
            numberOfOccurrences = 0;
        }
        return result;
    }
}