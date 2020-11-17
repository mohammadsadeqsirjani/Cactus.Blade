﻿using System;

public static partial class Extension
{
    /// <summary>
    ///     An object extension method that converts this object to a nullable float or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to a float?</returns>
    public static float? ToNullableSingleOrDefault(this object @this)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (float?)null : Convert.ToSingle(@this);
        }
        catch (Exception)
        {
            return default(float);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable float or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a float?</returns>
    public static float? ToNullableSingleOrDefault(this object @this, float? defaultValue)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (float?)null : Convert.ToSingle(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to a nullable float or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a float?</returns>
    public static float? ToNullableSingleOrDefault(this object @this, Func<float?> defaultValueFactory)
    {
        try
        {
            return @this == null || @this == DBNull.Value ? (float?)null : Convert.ToSingle(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}