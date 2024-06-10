using System;
using Entities.Interfaces;

namespace Entities.Models;

public class User : Person, ICrudEntity
{
    public User(long id, string identityCard, string names, string surnames, string phone, string email,
        DateTime createAt) : base(id, identityCard, names, surnames, phone, email, createAt)
    {
        Role = "user";
    }

    public User(string identityCard, string names, string surnames, string phone, string email, string? username, string? password) : base(names, identityCard, surnames, phone, email, username, password)
    {
        CreateAt = DateTime.Now;
        Role = "user";
    }

    public User()
    {
        Role = "user";
    }

    public User(long id, string identityCard, string names, string surnames, string phone, string email, string? username, string? password, DateTime createAt) : base(id, identityCard, names, surnames, phone, email, username, password, createAt)
    {
        Role = "user";
    }

}