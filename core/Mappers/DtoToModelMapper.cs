using core.DTOs;
using core.Mappers.Interfaces;
using data.Models;

namespace core.Mappers;

public class DtoToModelMapper : IDtoToModelMapper
{
    public User SignUpToUser(SignUpDto signUpDto)
    {
        return new User()
        {
            Username = signUpDto.Username,
            PasswordHash = signUpDto.Password,
            Email = signUpDto.Email,
            FirstName = signUpDto.FirstName,
            LastName = signUpDto.LastName,
            DateCreated = DateTime.UtcNow,
            Id = 0
        };
    }
}