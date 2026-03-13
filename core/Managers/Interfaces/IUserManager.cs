using System;
using core.DTOs;

namespace core.Managers.Interfaces;

public interface IUserManager
{
    Task<ProfileDto> SignUp(SignUpDto signUpDto);
    Task<bool> Login(LoginDto loginDto);
    Task<ProfileDto> GetProfile(int userId);
    Task EditProfile(ProfileDto userDetailsDto);
    Task DeleteAccount(int userId);
    Task EditPassword(int userId, string newPassword);
}
