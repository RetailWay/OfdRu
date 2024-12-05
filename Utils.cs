using System;
using System.Text;

namespace RetailWay.Integration.OfdRu
{
    internal static class Utils
    {
        public static void InsertPeriod(this StringBuilder builder, DateTime begin, DateTime end, char sep = '&')
        {
            builder.Append(sep);
            builder.Append("dateFrom=");
            builder.Append(begin.ToString(OfdRu.FORMAT_DATE));
            builder.Append("&dateTo=");
            builder.Append(end.ToString(OfdRu.FORMAT_DATE));
        }
    }
}
