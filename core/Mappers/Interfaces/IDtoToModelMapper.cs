using System;
using core.DTOs;
using data.Models;

namespace core.Mappers.Interfaces;

public interface IDtoToModelMapper
{
    User SignUpToUser(SignUpDto signUpDto);
}
