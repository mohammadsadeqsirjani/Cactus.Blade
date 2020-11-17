﻿using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to a nullable double or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a double?</returns>
    public static double? ToNullableDoubleOrDefault(this object @this)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (double?)null : Convert.ToDouble(@this);
        }
        catch (Exception)
        {
            return default(double);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable double or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a double?</returns>
    public static double? ToNullableDoubleOrDefault(this object @this, double? defaultValue)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (double?)null : Convert.ToDouble(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable double or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a double?</returns>
    public static double? ToNullableDoubleOrDefault(this object @this, Func<double?> defaultValueFactory)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (double?)null : Convert.ToDouble(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}