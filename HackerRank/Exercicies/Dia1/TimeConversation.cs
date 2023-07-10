using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Exercicies.Dia1
{
    public class TimeConversation
    {
        /*
         Given a time in -hour AM/PM format, convert it to military (24-hour) time.
         Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
         - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
         */
        public static string timeConversion(string s)
        {

            return DateTime.Parse(s).TimeOfDay.ToString();

        }

    }
}
