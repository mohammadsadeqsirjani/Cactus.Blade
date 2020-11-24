﻿using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extension
{
    /// <summary>
    ///     An ICollection&lt;T&gt; extension method that removes value that satisfy the predicate.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="predicate">The predicate.</param>
    public static void RemoveWhere<T>(this ICollection<T> @this, Func<T, bool> predicate)
    {
        var collection = @this.Where(predicate).ToList();

        foreach (var item in collection) @this.Remove(item);
    }
}