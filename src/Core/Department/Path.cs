namespace Core.Department;

public record Path
{
    private const char SEPARATOR = '.';
    public string Value { get; }

    private Path(string value)
    {
        Value = value;
    }

    public Path JoinWith(Identifier identifier)
    {
        return new Path($"{Value}{SEPARATOR}{identifier.Value}");
    }

    public static Path Create(Identifier identifier)
    {
        return new Path(identifier.Value);
    }
}
