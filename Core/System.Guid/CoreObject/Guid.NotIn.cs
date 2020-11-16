﻿// ReSharper disable once CheckNamespace
namespace Core.System.Guid
{
    public static partial class Extension
    {
        /// <summary>
        ///     A T extension method to determines whether the object is not equal to any of the provided values.
        /// </summary>
        /// <param name="this">The object to be compared.</param>
        /// <param name="values">The value list to compare with the object.</param>
        /// <returns>true if the values list doesn't contains the object, else false.</returns>
        /// ###
        public static bool NotIn(this global::System.Guid @this, params global::System.Guid[] values)
        {
            return global::System.Array.IndexOf(values, @this) == -1;
        }
    }
}
