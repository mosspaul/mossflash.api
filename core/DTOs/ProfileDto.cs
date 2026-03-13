
using data.Models;

namespace core.DTOs;

public class ProfileDto
{
    public ProfileDto(User user)
    {
        this.Email = user.Email;
        this. Username = user.Username;
        this.FirstName = user.FirstName;
        this.LastName = user.LastName;
        this.UserId = user.Id;
    }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int UserId { get; set; }
}