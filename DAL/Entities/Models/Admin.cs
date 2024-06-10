using System;
using Entities.Interfaces;

namespace Entities.Models;

public class Admin : Person, IReadEntity
{
    public Admin(long id, string identityCard, string names, string surnames, string phone, string email,
        DateTime createAt) : base(id, identityCard, names, surnames, phone, email, createAt)
    {
        Role = "admin";
    }

    public Admin()
    {
        Role = "admin";
    }
}