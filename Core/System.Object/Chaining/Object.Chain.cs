﻿using System;

// ReSharper disable once CheckNamespace
namespace Core.System.Object
{
    public static partial class Extension
    {
        /// <summary>
        ///     A T extension method that chains actions.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="action">The action.</param>
        /// <returns>The @this acted on.</returns>
        public static T Chain<T>(this T @this, Action<T> action)
        {
            action(@this);

            return @this;
        }
    }
}
