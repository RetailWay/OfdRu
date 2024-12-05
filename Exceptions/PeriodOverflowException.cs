using System;

namespace RetailWay.Integration.OfdRu.Exceptions
{
    public class PeriodOverflowException : Exception
    {
        public PeriodOverflowException(uint days) : base($"Разница границ периода превышает {days} д.") { }

        public static void ThrowIfGreat(DateTime begin, DateTime end, uint days)
        {
            if (Math.Abs((begin - end).TotalDays) > days)
                throw new PeriodOverflowException(days);
        }
        public static void ThrowIfGreatThanWeek(DateTime begin, DateTime end) => ThrowIfGreat(begin, end, 7);
        public static void ThrowIfGreatThanMonth(DateTime begin, DateTime end) => ThrowIfGreat(begin, end, 30);
    }
}
