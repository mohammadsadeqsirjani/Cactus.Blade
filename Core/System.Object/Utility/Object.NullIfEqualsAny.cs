﻿// ReSharper disable once CheckNamespace
namespace Core.System.Object
{
    public static partial class Extension
    {
        /// <summary>
        ///     A T extension method that null if equals any.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="this">The @this to act on.</param>
        /// <param name="values">A variable-length parameters list containing values.</param>
        /// <returns>A T.</returns>
        public static T NullIfEqualsAny<T>(this T @this, params T[] values) where T : class
        {
            return global::System.Array.IndexOf(values, @this) != -1 ? null : @this;
        }
    }
}
