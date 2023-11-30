using Domain.Enums;

namespace Domain.Models.Users.Parameters;

public record UserCreate(string UserName,
                         string Password,
                         string Email,
                         string FirstName,
                         string LastName,
                         Position Position);
