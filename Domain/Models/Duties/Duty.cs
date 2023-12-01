using Domain.Common;
using Domain.Enums;
using Domain.Models.Duties.Entities;
using Domain.Models.Users;

namespace Domain.Models.Duties;

public class Duty : BaseAuditableEntity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public TaskProgress Status { get; private set; }
    public Priority Priority { get; private set; }
    public User AsignedBy { get; private set; }
    public DateTime StartDateTime { get; private set; }
    public DateTime? EndDateTime { get; private set; }
    private readonly IList<DutyComment> _comments = [];
    public IReadOnlyList<DutyComment> Comments => _comments.AsReadOnly();


    public void AddComment(DutyComment comment)
    {
        _comments.Add(comment);
    }

}
