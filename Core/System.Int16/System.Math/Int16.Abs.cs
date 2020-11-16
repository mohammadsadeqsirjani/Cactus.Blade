﻿using System;
using System.Collections.Generic;
using System.Text;

// ReSharper disable once CheckNamespace
namespace Core.System.Int16
{
    public static partial class Extension
    {
        /// <summary>
        ///     Returns the absolute @this of a 16-bit signed integer.
        /// </summary>
        /// <param name="this">A number that is greater than , but less than or equal to .</param>
        /// <returns>A 16-bit signed integer, x, such that 0 ? x ?.</returns>
        public static short Abs(this short @this)
        {
            return Math.Abs(@this);
        }
    }
}
