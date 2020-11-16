﻿using System;

// ReSharper disable once CheckNamespace
namespace Core.System.Object
{
    public static partial class Extension
    {
        /// <summary>
        ///     A T extension method that null if.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>A T.</returns>
        public static T NullIf<T>(this T @this, Func<T, bool> predicate) where T : class
        {
            return predicate(@this) ? null : @this;
        }
    }
}
