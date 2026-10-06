using System.Globalization;
using Core.Shared;

namespace Core.Department;

public record Identifier
{
    public string Value { get; }

    private Identifier(string value)
    {
        Value = value;
    }

    public static Identifier Create(string identifier)
    {
        string valid_identifier = Name.Create(identifier).Value;
        string lowercase_identifier = valid_identifier.ToLower(CultureInfo.InvariantCulture);
        return new Identifier(lowercase_identifier);
    }
}
