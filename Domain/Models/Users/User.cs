using Domain.Common;
using Domain.Enums;
using Domain.Models.Users.Parameters;

namespace Domain.Models.Users;

public class User : BaseAuditableEntity
{
    public string UserName { get; private set; }
    public string UserEmail { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Position Position { get; private set; }
    public int Points { get; private set; }

    public User(UserCreate user)
    {
        UserName = user.UserName;
        UserEmail = user.Email;
        FirstName = user.FirstName;
        LastName = user.LastName;
        Position = user.Position;
        Points = 0;
    }
}

