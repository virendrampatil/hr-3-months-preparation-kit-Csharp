class Result
{
    public static long flippingBits(long n)
    {
        var n1 = (Int32)n;
        var flippedNumber = ~n1;
        var flippedBits = Convert.ToString(flippedNumber, 2);
        return Convert.ToInt64(flippedBits, 2);
    }
}