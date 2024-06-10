using System;
using DAL.Repositories;
using Entities.Models;
using Entities.Shared;

namespace BLL.Services;

public class AuthService
{
    private readonly AuthRepository _auth;
    private static Person? User;
    public AuthService()
    {
        this._auth = new();
    }

    public Response<String> Auth(Person person)
    {
        try
        {
            var res = _auth.Authenticate(person);
            if (res.IsSuccess) User = res.Data;
            return res.IsSuccess
                ? new ResponseBuilder<string>().WithSuccess(true).WithMsg("Bienvendio usuario!")
                : ResponseBuilder<string>.Fail("No se encuentra en nuestros registros.");
        }
        catch (Exception e)
        {
            return ResponseBuilder<String>.Error(e);
        }
    }
}