using Domain.Models.Duties.Parameters;
using System.Numerics;

namespace Domain.Models.Duties.Entities;

public class DutyComment
{
    public int UserId { get; set; }
    public string Comment { get; set; }
    public int? Likes { get; set; }
    public int? Dislikes { get; set; }

    private DutyComment()
    {

    }
    public DutyComment(DutyCommentCreate command)
    {
        UserId = command.UserId;
        Comment = command.Comment;
        Likes = 0;
        Dislikes = 0;
    }
}
