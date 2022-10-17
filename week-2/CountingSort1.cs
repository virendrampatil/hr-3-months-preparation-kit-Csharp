class Result
{
    public static List<int> countingSort(List<int> arr)
    {
        var countingArray = new int[100];
        foreach (var number in arr)
        {
            countingArray[number] += 1;
        }
        return countingArray.ToList();
    }
}