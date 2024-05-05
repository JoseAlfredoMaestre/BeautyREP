using Entities.Models;
using Entities.Shared;
using System.Linq;

namespace BLL.Services;

public class AuthenticationService
{
    private static AuthenticationService? _instance;

    private UserService UserService = UserService.GetInstance();

    public static AuthenticationService GetInstance() { return _instance ??= new AuthenticationService(); }
    private AuthenticationService()
    {
    }

    public Response<bool> ValidateUser(User user)
    {
        var list = UserService.GetAll().Data;
        var validate = list.Any(item => item.verifyCredentials(user.Username, user.Password));
        return new ResponseBuilder<bool>().WithSuccess(validate);

    }
}