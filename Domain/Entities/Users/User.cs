using Domain.Common;
using Domain.Entities.Users.Parameters;
using Domain.Enums;

namespace Domain.Entities.Users;

public class User : BaseAuditableEntity
{
    public string UserName { get; private set; }
    public string UserEmail { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Position Position { get; private set; }
    public int Points { get; private set; }

    public User(UserCreate command)
    {
        UserName = command.UserName;
        UserEmail = command.Email;
        FirstName = command.FirstName;
        LastName = command.LastName;
        Position = command.Position;
        Points = 0;
    }
}

