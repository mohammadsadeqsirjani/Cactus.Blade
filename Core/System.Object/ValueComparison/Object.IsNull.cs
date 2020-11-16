﻿// ReSharper disable once CheckNamespace
namespace Core.System.Object
{
    public static partial class Extension
    {
        /// <summary>
        ///     A T extension method that query if '@this' is null.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <returns>true if null, false if not.</returns>
        public static bool IsNull<T>(this T @this) where T : class
        {
            return @this == null;
        }
    }
}
