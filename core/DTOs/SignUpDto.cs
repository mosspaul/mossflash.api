using System.Text.Json.Serialization;
using core.Middleware.Interfaces;

namespace core.DTOs;

public class SignUpDto
{

    private readonly IEncrypter _encrypter;
    public SignUpDto(IEncrypter encrypter)
    {
        _encrypter = encrypter;
        // this.Password = _encrypter.Encrypt(this.Password);
    }
    [JsonPropertyName("username")]
    public required string Username { get; set; }
    [JsonPropertyName("email")]
    public required string Email { get; set; }
    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }
    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }
    [JsonPropertyName("password")]
    public required string Password { get; set; }
}