using TodoListExample.Core.Common;
using TodoListExample.Core.ValueObjects;

namespace TodoListExample.Core.Entities;

public class Label : AuditableEntity
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public Color Color { get; set; } = new(Color.SupportedColorCode.Amaranth);

    public ICollection<Todo> LabeledTodos { get; set; } = new List<Todo>();
}