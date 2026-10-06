namespace Core.Shared;

public record Name
{
    const int MaxNameLength = 256;
    const int MinNameLength = 3;

    public string Value { get; }

    private Name(string value)
    {
        Value = value;
    }

    public static Name Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Name cannot be null or empty.", nameof(value));
        }

        string trimmed = value.Trim();
        if (trimmed.Length < MinNameLength)
        {
            throw new ArgumentException(
                $"Name cannot be shorter than {MinNameLength} characters.",
                nameof(value)
            );
        }

        if (trimmed.Length > MaxNameLength)
        {
            throw new ArgumentException(
                $"Name cannot be longer than {MaxNameLength} characters.",
                nameof(value)
            );
        }

        return new Name(trimmed);
    }
}
