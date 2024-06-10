using System;
using BLL.Services;
using DAL.Connection;
using DAL.Repositories;
using Entities.Models;

namespace GUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var conexion = new DatabaseConnection();
            var res = conexion.OpenConnection();
            Console.WriteLine(res.IsSuccess + res.Msg);
            User newUser = new User();
            newUser.IdentityCard = "1067591313";
            newUser.Names = "Nombre de prueba";
            newUser.Surnames = "Apellido de prueba";
            newUser.Phone = "1234567890";
            newUser.Email = "prueba@ejemplo.com";
            newUser.Username = "prueba123";
            newUser.Password = "password123";
            newUser.CreateAt = DateTime.Now;

            UserRepository userRepository = new UserRepository();

            Console.WriteLine(userRepository.Insert(newUser).Msg);

            foreach (var user in userRepository.GetAll().Data)
            {
                Console.WriteLine(user.Names);
            }
        }
    }
}