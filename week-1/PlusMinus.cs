class Result
{
    public static void plusMinus(List<int> arr)
    {
        int length = arr.Count;
        decimal positive = 0.0m, negative = 0.0m, zero = 0.0m;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
                positive++;
            else if (arr[i] < 0)
                negative++;
            else
                zero++;
        }
        Console.WriteLine((positive / length).ToString("N6"));
        Console.WriteLine((negative / length).ToString("N6"));
        Console.WriteLine((zero / length).ToString("N6"));
    }
}
