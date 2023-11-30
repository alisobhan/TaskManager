using Domain.Common;

namespace Domain.Entities.Task;

public class TaskList : BaseAuditableEntity
{
    public string? Title { get; private set; }

    private readonly IList<Task> _tasks = [];
    private IReadOnlyCollection<Task> _tasksCollection => _tasks.AsReadOnly();

}
