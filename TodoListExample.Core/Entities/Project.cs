using TodoListExample.Core.Common;
using TodoListExample.Core.Enums;
using TodoListExample.Core.ValueObjects;

namespace TodoListExample.Core.Entities;

public class Project : AuditableEntity
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public Color? Color { get; set; }

    public ICollection<Todo> Items { get; set; } = new List<Todo>();
}