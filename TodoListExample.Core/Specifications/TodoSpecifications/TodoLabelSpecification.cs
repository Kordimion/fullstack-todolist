using TodoListExample.Core.Entities;
using TodoListExample.Core.Specifications.Shared;

namespace TodoListExample.Core.Specifications.TodoSpecifications;

public class TodoLabelSpecification : CompositeSpecification<Todo>
{
    private readonly int _labelId;

    public TodoLabelSpecification(int labelId)
    {
        _labelId = labelId;
    }

    public override bool IsSatisfiedBy(Todo candidate)
    {
        return candidate.Labels.Any(x => x.Id == _labelId);
    }
}