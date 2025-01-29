using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExtensionMethods.Extensions
{
    internal static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0) return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Horas";
            else return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
        }
    }
}
