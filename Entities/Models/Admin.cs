using System;
using Entities.Interfaces;

namespace Entities.Models;

public class Admin : Person, IReadEntity
{
    public Admin(long id, string names, string? surnames, string phone, string email, string? username,
        string? password, DateTime createAt) : base(id, names, surnames, phone, email, username, password, createAt)
    {
        Role = "admin";
    }

    public Admin()
    {
        Role = "admin";
    }
}