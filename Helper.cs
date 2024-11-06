using Pract5_Teslyuk_PR._22_101.Models;
using System;
using System.Linq;

namespace Pract5_Teslyuk_PR._22_101
{

    public class Helper
    {
        private static MusicRecordEntities _context;

        public static MusicRecordEntities GetContext()
        {
            if (_context == null)
                _context = new MusicRecordEntities();
            return _context;
        }

        public void CreateUser(UserAccounts user)
        {
            var context = GetContext();

            // Получаем последний ID, если таблица не пуста
            int maxId = context.UserAccounts.Any()
                ? context.UserAccounts.OrderByDescending(u => u.account_id).First().account_id
                : 0;

            user.account_id = maxId + 1;
            if (user.username != "" && user.password != "" && user.email != "" && user.role != "")
            {

                context.UserAccounts.Add(user);
                try
                {
                    context.SaveChanges();
                    Console.WriteLine("Пользователь успешно добавлен.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");

                }
            }
            else {
                Console.WriteLine("Не получилось создать пользователя, так как были введены не все необходимые данные");
            }
        }

    }

}
