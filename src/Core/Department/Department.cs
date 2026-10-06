using System.Text.RegularExpressions;
using Core.Shared;

namespace Core.Department;

/// <summary>
/// Подразделение (структурная единица) с поддержкой иерархии.
/// </summary>
public class Department
{
    /// <summary>Идентификатор подразделения.</summary>
    public Guid Id { get; private set; }

    /// <summary>Название подразделения.</summary>
    public Name Name { get; private set; }

    /// <summary>Псевдоним подразделения (только латиница).</summary>
    public Identifier Identifier { get; private set; }

    /// <summary>Идентификатор родителя (null у корневого подразделения).</summary>
    public Guid? ParentId { get; private set; }

    /// <summary>Путь подразделения в иерархии.</summary>
    public Core.Department.Path Path { get; private set; }

    /// <summary>Глубина подразделения на уровне иерархии.</summary>
    public short Depth { get; private set; }
    public bool IsActive => DeletedAt.HasValue;

    /// <summary>Дата создания подразделения (UTC).</summary>
    public DateTime CreatedAt { get; private set; }

    public DateTime? DeletedAt { get; private set; }

    /// <summary>Дата последнего изменения подразделения (UTC).</summary>
    public DateTime UpdatedAt { get; private set; }

    /// <summary>Псевдоним: начинается с латинской буквы, далее латиница, цифры, "_" или "-".</summary>
    private static readonly Regex IdentifierPattern = new(
        "^[A-Za-z][A-Za-z0-9_-]*$",
        RegexOptions.Compiled | RegexOptions.CultureInvariant
    );

    private Department(
        Guid id,
        Name name,
        Identifier identifier,
        Core.Department.Path path,
        short depth,
        DateTime createdAt,
        DateTime updatedAt,
        DateTime? deletedAt = null,
        Guid? parentId = null
    )
    {
        Id = id;
        Name = name;
        Identifier = identifier;
        ParentId = parentId;
        Path = path;
        Depth = depth;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        DeletedAt = deletedAt;
    }

    /// <summary>
    /// Создаёт подразделение. Parent = null — подразделение становится корневым.
    /// </summary>
    public static Department CreateNewRoot(Name name, Identifier identifier)
    {
        var created_at = DateTime.UtcNow;
        Core.Department.Path path = Core.Department.Path.Create(identifier);
        var id = Guid.NewGuid();
        return new Department(id, name, identifier, path, 0, created_at, created_at);
    }

    public static Department Create(
        Guid id,
        Guid? parentId,
        Name name,
        Identifier identifier,
        Core.Department.Path path,
        short depth,
        DateTime createdAt,
        DateTime updatedAt,
        DateTime? deletedAt = null
    )
    {
        return new Department(
            id,
            name,
            identifier,
            path,
            depth,
            createdAt,
            updatedAt,
            deletedAt,
            parentId
        );
    }
}
