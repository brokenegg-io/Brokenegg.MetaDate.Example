using System;

namespace Brokenegg.MetaDate.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.ParseExact("25/10/2021 20:25", "dd/MM/yyyy HH:mm", null);
            USettings.Locale = ULocale.FindLocale(ELocales.MANAUS);

            var uDate = new UDate(date);
            
            var local =  uDate.ToLocalDateTime();
            var utc = uDate.ToUtcDateTime();

            Console.WriteLine(local.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine(utc.ToString("dd/MM/yyyy HH:mm"));

        }
    }
}
