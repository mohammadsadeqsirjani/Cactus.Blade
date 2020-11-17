﻿using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to a nullable u int 64 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to an ulong?</returns>
    public static ulong? ToNullableUInt64OrDefault(this object @this)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (ulong?)null : Convert.ToUInt64(@this);
        }
        catch (Exception)
        {
            return default(ulong);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable u int 64 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to an ulong?</returns>
    public static ulong? ToNullableUInt64OrDefault(this object @this, ulong? defaultValue)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (ulong?)null : Convert.ToUInt64(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable u int 64 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to an ulong?</returns>
    public static ulong? ToNullableUInt64OrDefault(this object @this, Func<ulong?> defaultValueFactory)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (ulong?)null : Convert.ToUInt64(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}