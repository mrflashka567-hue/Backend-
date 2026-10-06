namespace Core.Location;

/// <summary>
/// Локация (офис, филиал и т.п.).
/// </summary>
public class Location
{
    /// <summary>Идентификатор локации.</summary>
    public Guid Id { get; private set; } = Guid.NewGuid();

    /// <summary>Адрес.</summary>
    public string Address { get; private set; } = string.Empty;

    /// <summary>Название локации.</summary>
    public string Name { get; private set; } = string.Empty;

    /// <summary>IANA код локации (например, "Europe/Moscow").</summary>
    public string TimeZone { get; private set; } = "UTC";

    /// <summary>Дата создания локации (UTC).</summary>
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;

    /// <summary>Дата обновления локации (UTC).</summary>
    public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
}
