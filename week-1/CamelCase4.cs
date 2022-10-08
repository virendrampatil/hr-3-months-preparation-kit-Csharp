using System.Text;

class Solution
{
    static void Main(String[] args)
    {
        var reader = new StreamReader(Console.OpenStandardInput());
        var inputs = reader.ReadToEnd().Split("\r\n").Where(x => x != "").ToList();
        var result = string.Empty;

        foreach (var str in inputs)
        {
            var arr = str.Split(';').ToArray();
            if (arr[0] == "S")
            {
                result = SplitTheWord(arr[2]);
            }
            else
            {
                result = CombineTheWord(arr[1], arr[2]);
            }
            Console.WriteLine(result);
        }
    }

    private static string SplitTheWord(string word)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < word.Length; i++)
        {
            if (!Char.IsLetter(word[i]))
            {
                continue;
            }
            else if (Char.IsUpper(word[i]))
            {
                sb.Append(' ');
            }

            sb.Append(Char.ToLower(word[i]));
        }
        return sb.ToString().TrimStart();
    }

    private static string CombineTheWord(string type, string word)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == ' ')
            {
                sb.Append(Char.ToUpper(word[i + 1]));
                i++;
                continue;
            }
            sb.Append(word[i]);
        }
        if (type == "C")
        {
            sb[0] = Char.ToUpper(sb[0]);
        }
        else if (type == "M")
        {
            sb.Append("()");
        }

        return sb.ToString();
    }
}