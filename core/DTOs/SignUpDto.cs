using core.Middleware.Interfaces;

namespace core.DTOs;

public class SignUpDto
{

    private readonly IEncrypter _encrypter;
    public SignUpDto(IEncrypter encrypter)
    {
        _encrypter = encrypter;
        this.Password = _encrypter.Encrypt(this.Password);
    }

    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Password { get; set; }
}