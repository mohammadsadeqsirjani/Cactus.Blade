﻿using System;

// ReSharper disable once CheckNamespace
namespace Core.System.Double
{
    public static partial class Extension
    {
        /// <summary>
        ///     Returns the angle whose tangent is the specified number.
        /// </summary>
        /// <param name="this">A number representing a tangent.</param>
        /// <returns>
        ///     An angle, ?, measured in radians, such that -?/2 ????/2.-or-  if  equals , -?/2 rounded to double precision (-
        ///     1.5707963267949) if  equals , or ?/2 rounded to double precision (1.5707963267949) if  equals .
        /// </returns>
        public static double Atan(this double @this)
        {
            return Math.Atan(@this);
        }
    }
}
