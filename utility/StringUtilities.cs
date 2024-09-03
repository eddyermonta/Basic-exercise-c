public class StringUtilities
{
    enum Vowels { a = 'a', e = 'e', i = 'i', o = 'o', u = 'u' };

    public static int CountVowels(string input)
    {
        int count = 0;
        input = input.ToLower().Trim();
        foreach (char c in input)
        {
            if (Enum.IsDefined(typeof(Vowels), (int)c))
            {
                count++;
            }
        }
        return count;
    }
}