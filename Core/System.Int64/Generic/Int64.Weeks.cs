﻿using System;

// ReSharper disable once CheckNamespace
namespace Core.System.Int64
{
    public static partial class Extension
    {
        /// <summary>
        ///     An Int64 extension method that weeks the given this.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <returns>A TimeSpan.</returns>
        public static TimeSpan Weeks(this long @this)
        {
            return TimeSpan.FromDays(@this * 7);
        }
    }
}
