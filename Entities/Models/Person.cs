using System;

namespace Entities.Models;

public abstract class Person
{

    public Person(long id, string names, string? surnames, string phone, string email, string? username,
        string? password, DateTime createAt)
    {
        Id = id;
        Names = names;
        Surnames = surnames;
        Phone = phone;
        Email = email;
        Username = username;
        Password = password;
        CreateAt = createAt;
    }

    public Person(string names, string? surnames, string phone, string email, string? username, string? password)
    {
        Names = names;
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


    public long Id { get; set; }
    public string Names { get; set; }
    public string? Surnames { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    private string? Username { get; }
    private string? Password { get; }
    public DateTime CreateAt { get; set; }
    public string? Role { get; protected set; }

    public bool verifyCredentials(string username, string password)
    {
        return username == Username && password == Password;
    }
}