namespace TypeDetect;

/// <summary>
/// <para>Type detection language extension, no memory overhead is allocated.</para>
/// <para>Example:</para>
/// <para>".IsDateTime()" returns true if the object is a datetime and false otherwise.</para>
/// <para>".IsDateTimeNullable()" returns true if the object is a datetime OR null, and false otherwise.</para>
/// <para>".IsNumeric()" returns true if the object is "int", "short", "double", ...</para>
/// <para>".IsNumericNullable()" as before, including null values.</para>
/// <para>".IsText()" returns true for strings and chars.</para>
/// <para>".IsTextNullable()" as before, including null values.</para>
/// </summary>
public static class ExtTypeDetect
{
    #region Object
    /// <summary>
    /// Check if an object is a base type (bool, char, string, or numbers as int and long).
    /// <para> This differs from C#'s Type.IsPrimitive property as it also considers strings
    /// as base types.</para>
    /// </summary>
    public static bool IsBaseType(this object o) => o.IsText() || o.IsNumeric() || o.IsBool();

    /// <summary>
    /// Check if an object is a base type (bool, char, string, or numbers as int and long) or null.
    /// It also checks for DBNull so it can be used for database query results.
    /// <para> This differs from C#'s Type.IsPrimitive property as it also considers strings
    /// as base types.</para>
    /// </summary>
    public static bool IsBaseTypeNullable(this object o) => o.IsTextNullable() || o.IsNumericNullable() || o.IsBoolNullable();

    /// <summary>
    /// Check if an object is a number type (byte, short, int, long, float, double, decimal) both signed and unsigned.
    /// </summary>
    public static bool IsNumeric(this object o)
    {
        return Type.GetTypeCode(o.GetType()) switch
        {
            TypeCode.Byte or
            TypeCode.SByte or
            TypeCode.UInt16 or
            TypeCode.UInt32 or
            TypeCode.UInt64 or
            TypeCode.Int16 or
            TypeCode.Int32 or
            TypeCode.Int64 or
            TypeCode.Decimal or
            TypeCode.Double or
            TypeCode.Single => true,
            _ => false
        };
    }

    /// <summary>
    /// Check if an object is a number type (byte, short, int, long, float, double, decimal) both signed and unsigned, or null.
    /// It also checks for DBNull so it can be used for database query results.
    /// </summary>
    public static bool IsNumericNullable(this object o)
    {
        return Type.GetTypeCode(o.GetType()) switch
        {
            TypeCode.Empty or
            TypeCode.DBNull or
            TypeCode.Byte or
            TypeCode.SByte or
            TypeCode.UInt16 or
            TypeCode.UInt32 or
            TypeCode.UInt64 or
            TypeCode.Int16 or
            TypeCode.Int32 or
            TypeCode.Int64 or
            TypeCode.Decimal or
            TypeCode.Double or
            TypeCode.Single => true,
            _ => false
        };
    }

    /// <summary>
    /// Check if an object is a char or a string.
    /// </summary>
    public static bool IsText(this object o)
    {
        return Type.GetTypeCode(o.GetType()) switch
        {
            TypeCode.Char or
            TypeCode.String => true,
            _ => false
        };
    }

    /// <summary>
    /// Check if an object is a char or string, or null.
    /// It also checks for DBNull so it can be used for database query results.
    /// </summary>
    public static bool IsTextNullable(this object o)
    {
        return Type.GetTypeCode(o.GetType()) switch
        {
            TypeCode.Empty or
            TypeCode.DBNull or
            TypeCode.Char or
            TypeCode.String => true,
            _ => false
        };
    }

    /// <summary>
    /// Check if an object is a string.
    /// </summary>
    public static bool IsString(this object o) => Type.GetTypeCode(o.GetType()) == TypeCode.String;

    /// <summary>
    /// Check if an object is a string or null.
    /// It also checks for DBNull so it can be used for database query results.
    /// </summary>
    public static bool IsStringNullable(this object o)
    {
        return Type.GetTypeCode(o.GetType()) switch
        {
            TypeCode.Empty or
            TypeCode.DBNull or
            TypeCode.String => true,
            _ => false
        };
    }
    //
    /// <summary>
    /// Check if an object is a char.
    /// </summary>
    public static bool IsChar(this object o) => Type.GetTypeCode(o.GetType()) == TypeCode.Char;

    /// <summary>
    /// Check if an object is a char or null.
    /// It also checks for DBNull so it can be used for database query results.
    /// </summary>
    public static bool IsCharNullable(this object o)
    {
        return Type.GetTypeCode(o.GetType()) switch
        {
            TypeCode.Empty or
            TypeCode.DBNull or
            TypeCode.Char => true,
            _ => false
        };
    }
    //

    /// <summary>
    /// Check if an object is a boolean.
    /// </summary>
    public static bool IsBool(this object o) => Type.GetTypeCode(o.GetType()) == TypeCode.Boolean;

    /// <summary>
    /// Check if an object is a boolean or null.
    /// It also checks for DBNull so it can be used for database query results.
    /// </summary>
    public static bool IsBoolNullable(this object o)
    {
        return Type.GetTypeCode(o.GetType()) switch
        {
            TypeCode.DBNull or
            TypeCode.Boolean => true,
            _ => false
        };
    }

    /// <summary>
    /// Check if an object is of DateTime type.
    /// </summary>
    public static bool IsDateTime(this object o) => Type.GetTypeCode(o.GetType()) == TypeCode.DateTime;

    /// <summary>
    /// Check if an object is of DateTime type or null.
    /// It also checks for DBNull so it can be used for database query results.
    /// </summary>
    public static bool IsDateTimeNullable(this object o)
    {
        return Type.GetTypeCode(o.GetType()) switch
        {
            TypeCode.Empty or
            TypeCode.DBNull or
            TypeCode.DateTime => true,
            _ => false
        };
    }
    #endregion Object

    #region Type
    /// <summary>
    /// Check if a type is a base type (bool, char, string, or numbers as int and long).
    /// <para> This differs from C#'s Type.IsPrimitive property as it also considers strings
    /// as base types.</para>
    /// </summary>
    public static bool IsBaseType(this Type t) => t.IsText() || t.IsNumeric() || t.IsBool();

    /// <summary>
    /// Check if a type is a base type (bool, char, string, or numbers as int and long) or null.
    /// It also checks for DBNull so it can be used for database query results.
    /// <para> This differs from C#'s Type.IsPrimitive property as it also considers strings
    /// as base types.</para>
    /// </summary>
    public static bool IsBaseTypeNullable(this Type t) => t.IsTextNullable() || t.IsNumericNullable() || t.IsBoolNullable();

    /// <summary>
    /// Check if a type is a number type (byte, short, int, long, float, double, decimal) both signed and unsigned.
    /// </summary>
    public static bool IsNumeric(this Type t) =>
        t == typeof(int) || t == typeof(double) || t == typeof(float) || t == typeof(decimal) || t == typeof(uint) ||
        t == typeof(byte) || t == typeof(long) || t == typeof(short) || t == typeof(ushort) || t == typeof(ulong) || t == typeof(sbyte);

    /// <summary>
    /// Check if a type is a number type (byte, short, int, long, float, double, decimal) both signed and unsigned, or null.
    /// It checks for DBNull so it can be used for database query results.
    /// </summary>
    public static bool IsNumericNullable(this Type t) =>
        t == typeof(int) || t == typeof(double) || t == typeof(float) || t == typeof(DBNull) || t == typeof(decimal) || t == typeof(uint) ||
        t == typeof(byte) || t == typeof(long) || t == typeof(short) || t == typeof(ushort) || t == typeof(ulong) || t == typeof(sbyte);

    /// <summary>
    /// Check if a type is a char or a string.
    /// </summary>
    public static bool IsText(this Type t) => t == typeof(char) || t == typeof(string);
    /// <summary>
    /// Check if a type is a char or string, or null.
    /// It checks for DBNull so it can be used for database query results.
    /// </summary>
    public static bool IsTextNullable(this Type t) => t == typeof(char) || t == typeof(string) || t == typeof(DBNull);

    /// <summary>
    /// Check if a type is a boolean.
    /// </summary>
    public static bool IsBool(this Type t) => t == typeof(bool);
    /// <summary>
    /// Check if a type is a boolean or null.
    /// It checks for DBNull so it can be used for database query results.
    /// </summary>
    public static bool IsBoolNullable(this Type t) => t == typeof(bool) || t == typeof(DBNull);

    /// <summary>
    /// Check if a type is of DateTime type.
    /// </summary>
    public static bool IsDateTime(this Type t) => t == typeof(DateTime);

    /// <summary>
    /// Check if a type is of DateTime type or null.
    /// It checks for DBNull so it can be used for database query results.
    /// </summary>
    public static bool IsDateTimeNullable(this Type t) => t == typeof(DateTime) || t == typeof(DBNull);
    #endregion Type
}
