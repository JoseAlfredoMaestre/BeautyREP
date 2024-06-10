using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Person
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

    public Person(long id, string identityCard, string names, string surnames, string phone, string email, string? username, string? password, DateTime createAt, string? role)
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
        Role = role;
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

    //Se usan anotaciones para validar los campos via DataAnnotations / Vendrian a ser validaciones para el formulario
    [Required(ErrorMessage = "El campo cédula es requerido.")]
    [StringLength(10, ErrorMessage = "La cédula no puede tener más de 10 caracteres.")]
    public string IdentityCard { get; set; }

    [Required(ErrorMessage = "El campo nombres es requerido.")]
    [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
    public string Names { get; set; }

    [Required(ErrorMessage = "El campo apellidos es requerido.")]
    [StringLength(50, ErrorMessage = "Los apellidos no pueden tener más de 50 caracteres.")]
    public string Surnames { get; set; }

    [Required(ErrorMessage = "El campo teléfono es requerido.")]
    [Phone(ErrorMessage = "El campo teléfono no es válido.")]
    [StringLength(15, ErrorMessage = "El teléfono no puede tener más de 15 caracteres.")]
    public string Phone { get; set; }

    [Required(ErrorMessage = "El campo email es requerido.")]
    [EmailAddress(ErrorMessage = "El campo email no es válido.")]
    [StringLength(100, ErrorMessage = "El email no puede tener más de 100 caracteres.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "El campo nombre de usuario es requerido.")]
    [StringLength(20, ErrorMessage = "El nombre de usuario no puede tener más de 20 caracteres.")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "El campo contraseña es requerido.")]
    [StringLength(20, ErrorMessage = "La contraseña no puede tener más de 20 caracteres.")]
    public string? Password { get; set; }

    public DateTime CreateAt { get; set; }

    public string? Role { get; protected set; }

    public bool verifyCredentials(string username, string password)
    {
        return username == Username && password == Password;
    }
}