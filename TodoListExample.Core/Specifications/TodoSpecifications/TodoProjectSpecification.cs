using TodoListExample.Core.Entities;
using TodoListExample.Core.Specifications.Shared;

namespace TodoListExample.Core.Specifications.TodoSpecifications;

public class TodoProjectSpecification : CompositeSpecification<Todo>
{
    private readonly int _projectId;

    public TodoProjectSpecification(int projectId)
    {
        _projectId = projectId;
    }

    public override bool IsSatisfiedBy(Todo candidate)
    {
        return candidate.ProjectId == _projectId;
    }
}