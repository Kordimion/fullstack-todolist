namespace TodoListExample.Core.Common;

// ReSharper disable once IdentifierTypo
public abstract class AuditableEntity
{
    public DateTime Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModified { get; set; }

    public string? LastModifiedBy { get; set; }
}