using System;

namespace PropsInDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Propriedades");
            Console.WriteLine("---------------------------------------\n");
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("\nFormatação (DateTime -> string)");
            Console.WriteLine("-------------------------------------------------\n");

            DateTime f = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = f.ToLongDateString();
            string s2 = f.ToLongTimeString();
            string s3 = f.ToShortDateString();
            string s4 = f.ToShortTimeString();
            string s5 = f.ToString();
            string s6 = f.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = f.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("\nOperações com DateTime)");
            Console.WriteLine("---------------------------------------\n");

            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime g = x.Add(new TimeSpan(1, 1, 1));
            DateTime h = x.AddDays(1);
            DateTime i = x.AddHours(1);
            DateTime j = x.AddMilliseconds(1);
            DateTime k = x.AddMinutes(1);
            DateTime l = x.AddMonths(1);
            DateTime m = x.AddSeconds(1);
            DateTime n = x.AddTicks(900000000L);
            DateTime o = x.AddYears(1);
            DateTime p = x.Subtract(new TimeSpan(1, 1, 1));
            TimeSpan q = x.Subtract(DateTime.Now);

            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(o);
            Console.WriteLine(p);
            Console.WriteLine(q);
        }
    }
}