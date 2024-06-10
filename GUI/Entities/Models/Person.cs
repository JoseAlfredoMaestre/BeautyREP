using System;

namespace Entities.Models;

public abstract class Person
{

    public Person(long id, string identityCard, string names, string surnames, string phone, string email, DateTime createAt)
    {
        Id = id;
        IdentityCard = identityCard;
        Names = names;
        Surnames = surnames;
        Phone = phone;
        Email = email;
        CreateAt = createAt;
    }

    public Person( string identityCard, string names, string surnames, string phone, string email, string? username, string? password)
    {
        Names = names;
        IdentityCard = identityCard;
        Surnames = surnames;
        Phone = phone;
        Email = email;
        Username = username;
        Password = password;
        CreateAt = DateTime.Now;
    }

    public Person()
    {
    }

    protected Person(long id, string identityCard, string names, string surnames, string phone, string email, string? username, string? password, DateTime createAt)
    {
        Id = id;
        IdentityCard = identityCard;
        Names = names;
        Surnames = surnames;
        Phone = phone;
        Email = email;
        Username = username;
        Password = password;
        CreateAt = createAt;
    }
    public long Id { get; set; }
    public string IdentityCard { get; set; }
    public string Names { get; set; }
    public string Surnames { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public DateTime CreateAt { get; set; }
    public string? Role { get; protected set; }

    public bool verifyCredentials(string username, string password)
    {
        return username == Username && password == Password;
    }
}