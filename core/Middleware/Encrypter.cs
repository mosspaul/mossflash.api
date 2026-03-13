using System;
using core.Middleware.Interfaces;

namespace core.Middleware;

public class Encrypter : IEncrypter
{
    public string Decrypt(string password)
    {
        
        return password;
    }

    public string Encrypt(string password)
    {
        if (password == null)
        {
            throw new NullReferenceException();
        }
        return password;
    }
}
