class Result
{
    public static int miniMaxSum(List<int> arr)
    {
        var min = int.MaxValue;
        var max = int.MinValue;
        var sum = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i];
            if (arr[i] > max)
                max = arr[i];
            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine($"{sum - max} {sum - min}");
    }
}
