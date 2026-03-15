using System;

namespace core.Middleware.Interfaces;

public interface IEncrypter
{
    string Encrypt(string password);
    string Decrypt(string password);
}
