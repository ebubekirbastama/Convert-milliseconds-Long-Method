       
using System.Data;


namespace ebstimecms
{
    public class Firmalar
    {

        public static String convertt(string mins)
        {
            var startdate = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(mins)).UtcDateTime;
            return startdate.ToString();
        }

    }
}
