using core.DTOs;
using core.Managers.Interfaces;
using core.Mappers.Interfaces;
using data.Repositories.Interfaces;

namespace core.Managers;

public class UserManager : IUserManager
{
    private readonly IMossFlashRepository _repo;
    private readonly IDtoToModelMapper _dtoToModelMapper;
    public UserManager(
        IMossFlashRepository repo, 
        IDtoToModelMapper dtoToModelMapper
        )
    {
        _repo = repo;
        _dtoToModelMapper = dtoToModelMapper;
    }
    public async Task DeleteAccount(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task EditPassword(int userId, string newPassword)
    {
        throw new NotImplementedException();
    }

    public async Task EditProfile(ProfileDto userDetailsDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ProfileDto> GetProfile(int userId)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Login(LoginDto loginDto)
    {
        bool isLoggedIn = await _repo.Login(loginDto.Username, loginDto.Password);
        return isLoggedIn;
    }

    public async Task<ProfileDto> SignUp(SignUpDto signUpDto)
    {
        var user = _dtoToModelMapper.SignUpToUser(signUpDto);
        var createdUser = await _repo.SignUp(user);
        return new ProfileDto(createdUser);
    }
}