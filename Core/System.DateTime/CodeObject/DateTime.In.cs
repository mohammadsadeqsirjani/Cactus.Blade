﻿// ReSharper disable once CheckNamespace
namespace Core.System.DateTime
{
    public static partial class Extension
    {
        /// <summary>
        ///     A T extension method to determines whether the object is equal to any of the provided values.
        /// </summary>
        /// <param name="this">The object to be compared.</param>
        /// <param name="values">The value list to compare with the object.</param>
        /// <returns>true if the values list contains the object, else false.</returns>
        /// ###
        /// <typeparam name="T">Generic type parameter.</typeparam>
        public static bool In(this global::System.DateTime @this, params global::System.DateTime[] values)
        {
            return global::System.Array.IndexOf(values, @this) != -1;
        }
    }
}
