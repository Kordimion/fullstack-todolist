using TodoListExample.Core.Common;

namespace TodoListExample.Core.Entities;

public class Todo : AuditableEntity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool IsCompleted { get; set; }

    public int? ProjectId { get; set; }

    public Project? Project { get; set; }

    public ICollection<Label> Labels { get; set; } = new List<Label>();
}