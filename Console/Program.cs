using System;
using BLL.Services;
using Entities.Models;

namespace GUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var user = new User(1, "aisaac", "asd", "123123", "email.com", "aisaac", "1234", DateTime.Now);
            var user2 = new User(2, "aisaacInsano", "asd", "123123", "email.com", "aisaac", "1234", DateTime.Now);
            var user4 = new User(2, "aisaacInsano", "asd", "123123", "email.com", "aisaac", "1234", DateTime.Now);

            Console.WriteLine(UserService.GetInstance().Save(user));
            Console.WriteLine(UserService.GetInstance().Save(user2));

            foreach (var item in UserService.GetInstance().GetAll().Data)
            {
                Console.WriteLine(item.Id + item.Names + item.CreateAt);
            }
            Console.WriteLine();
            var user3 = new User(3, "aisaacInsano43", "asd", "123123", "email.com", "aisaac", "1234", DateTime.Now);
            UserService.GetInstance().Save(user, user2, user3, user4);

            foreach (var item in UserService.GetInstance().GetAll().Data)
            {
                Console.WriteLine(item.Id + item.Names + item.CreateAt);
            }
            Console.ReadLine();
        }
    }
}