using System;
using HashPasswords;

using System.Threading.Tasks;
using Pract5_Teslyuk_PR._22_101.Models;

namespace Pract5_Teslyuk_PR._22_101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя:");
            string username = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();
            Console.WriteLine("Введите email:");
            string email = Console.ReadLine();
            Console.WriteLine("Введите роль:");
            string role = Console.ReadLine();

            // Хешируем пароль
            string hashedPassword = Hash.ConvertTo_SHA256(password);

            UserAccounts newUser = new UserAccounts
            {
                username = username,
                password = hashedPassword,
                email = email,
                role = role
            };

            Helper helper = new Helper();
            helper.CreateUser(newUser);
        }
    }
}
