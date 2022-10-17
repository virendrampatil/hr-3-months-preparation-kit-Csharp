class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int lSum = 0, rSum = 0;
        for (int i = 0, j = arr.Count - 1; i < arr.Count; i++, j--)
        {
            lSum += arr[i][i];
            rSum += arr[i][j];
        }
        return Math.Abs(lSum - rSum);
    }
}