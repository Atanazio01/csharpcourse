using System.Globalization;

namespace ExtensionMethods.Extensions;
static class DateTimeExtensions
{
    public static string ElapsedTime(this DateTime dt)
    {
        TimeSpan duration = DateTime.Now - dt;

        if(duration.TotalHours < 24.0)
        {
            return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
        }
        else
        {
            return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
        }
    }
}
