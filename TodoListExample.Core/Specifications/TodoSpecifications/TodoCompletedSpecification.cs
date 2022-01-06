using TodoListExample.Core.Entities;
using TodoListExample.Core.Specifications.Shared;

namespace TodoListExample.Core.Specifications.TodoSpecifications;

public class TodoCompletedSpecification : CompositeSpecification<Todo>
{
    public override bool IsSatisfiedBy(Todo candidate)
    {
        return candidate.IsCompleted;
    }
}