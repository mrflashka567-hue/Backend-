namespace Core.Position;

/// <summary>
/// Должность (позиция) сотрудника.
/// </summary>
public class Position
{
    /// <summary>Идентификатор позиции.</summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>Название позиции.</summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>Описание позиции.</summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>Активна позиция или нет.</summary>
    public bool IsActive { get; set; } = true;

    /// <summary>Дата создания позиции (UTC).</summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>Дата обновления позиции (UTC).</summary>
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
