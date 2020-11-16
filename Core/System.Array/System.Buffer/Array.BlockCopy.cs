﻿// ReSharper disable once CheckNamespace
namespace Core.System.Array
{
    public static partial class Extension
    {
        /// <summary>
        ///     Copies a specified number of bytes from a source array starting at a particular offset to a destination array
        ///     starting at a particular offset.
        /// </summary>
        /// <param name="source">The source buffer.</param>
        /// <param name="sourceOffset">The zero-based byte offset into .</param>
        /// <param name="destination">The destination buffer.</param>
        /// <param name="destinationOffset">The zero-based byte offset into .</param>
        /// <param name="count">The number of bytes to copy.</param>
        public static void BlockCopy(this global::System.Array source, int sourceOffset,
            global::System.Array destination,
            int destinationOffset, int count)
        {
            global::System.Buffer.BlockCopy(source, sourceOffset, destination, destinationOffset, count);
        }
    }
}
