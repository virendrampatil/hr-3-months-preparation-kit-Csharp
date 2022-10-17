class Result
{
    public static int marsExploration(string s)
    {
        var changedLettersCount = 0;
        for (int i = 0; i < s.Length - 2; i += 3)
        {
            if (s[i] != 'S')
                changedLettersCount++;
            if (s[i + 1] != 'O')
                changedLettersCount++;
            if (s[i + 2] != 'S')
                changedLettersCount++;
        }
        return changedLettersCount;
    }
}