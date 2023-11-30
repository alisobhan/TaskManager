using Domain.Common;
using Domain.Enums;

namespace Domain.Entities.Task;

public class Task : BaseAuditableEntity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public Priority Priority { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime? EndDateTime { get; private set; }

}
