using Pract5_Teslyuk_PR._22_101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            // Устанавливаем ID для нового пользователя, увеличив на 1
            user.account_id = maxId + 1;

            context.UserAccounts.Add(user);
            try
            {
                context.SaveChanges();
                Console.WriteLine("Пользователь успешно добавлен.");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
        }

    }

}
