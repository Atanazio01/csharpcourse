namespace ExtensionMethods.Extensions;
static class StringExtensions
{
    public static string Cut(this string str, int length)
    {
        if(str.Length <= length)
        {
            return str;
        }
        else
        {
            return str.Substring(0, length) + "...";
        }
    }
}
