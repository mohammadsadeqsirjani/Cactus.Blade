﻿using System;

// ReSharper disable once CheckNamespace
namespace Core.System.Double
{
    public static partial class Extension
    {
        /// <summary>
        ///     Returns the base 10 logarithm of a specified number.
        /// </summary>
        /// <param name="this">A number whose logarithm is to be found.</param>
        /// <returns>
        ///     One of the values in the following table.  parameter Return value Positive The base 10 log of ; that is, log
        ///     10. Zero Negative Equal to Equal to.
        /// </returns>
        public static double Log10(this double @this)
        {
            return Math.Log10(@this);
        }
    }
}
