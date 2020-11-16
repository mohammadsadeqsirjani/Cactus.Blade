﻿using System;

namespace Core.System.DateTime
{
    public static partial class Extension
    {
        /// <summary>
        ///     A DateTime extension method that starts of week.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="startDayOfWeek">(Optional) the start day of week.</param>
        /// <returns>A DateTime.</returns>
        public static global::System.DateTime StartOfWeek(this global::System.DateTime @this,
            DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
        {
            var start = new global::System.DateTime(@this.Year, @this.Month, @this.Day);

            if (start.DayOfWeek == startDayOfWeek) return start;

            var dayOfWeek = startDayOfWeek - start.DayOfWeek;

            return startDayOfWeek <= start.DayOfWeek
                ? start.AddDays(dayOfWeek)
                : start.AddDays(-7 + dayOfWeek);

        }
    }
}
