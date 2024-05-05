using System;
using Entities.Interfaces;

namespace Entities.Models;

public class User : Person, ICrudEntity
{
    public User(long id, string names, string? surnames, string phone, string email, string? username, string? password,
        DateTime createAt) : base(id, names, surnames, phone, email, username, password, createAt)
    {
        Role = "user";
    }

    public User()
    {
        Role = "user";
    }

}