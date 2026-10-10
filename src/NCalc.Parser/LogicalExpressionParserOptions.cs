namespace NCalc;

/// <summary>
/// Options for configuring the LogicalExpressionParser behavior.
/// </summary>
public sealed class LogicalExpressionParserOptions
{
    /// <summary>
    /// Parses single-quoted one-character values as <see cref="char"/>.
    /// </summary>
    public bool AllowCharValues { get; init; }

    /// <summary>
    /// Disallows the single equals sign (<c>=</c>) as an equality operator, requiring <c>==</c> instead.
    /// </summary>
    public bool DisallowSingleEquals { get; init; }

    /// <summary>
    /// Characters a function name may contain besides letters, digits and underscores, such as
    /// <c>.</c> for qualified names like <c>owner.name()</c>. They cannot start or end the name.
    /// Only a name followed by a parenthesis is read this way, so with <c>-</c> allowed,
    /// <c>a-b(1)</c> calls <c>a-b</c> while <c>a-b</c> and <c>a - b(1)</c> remain subtractions.
    /// </summary>
    public string FunctionNameCharacters { get; init; } = string.Empty;

    /// <summary>
    /// Gets the default parsed floating point number type.
    /// </summary>
    public FloatingPointNumberType FloatingPointNumberType { get; init; } = FloatingPointNumberType.Double;

    /// <summary>
    /// Gets the default parsed integer number type.
    /// </summary>
    public IntegerNumberType IntegerNumberType { get; init; } = IntegerNumberType.Int32;

    /// <summary>
    /// The argument separator used to separate function arguments. Default is Comma.
    /// </summary>
    public ArgumentSeparator ArgumentSeparator { get; init; } = ArgumentSeparator.Comma;
}
