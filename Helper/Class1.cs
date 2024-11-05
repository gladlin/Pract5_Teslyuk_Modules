using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class Helper
    {
        public static MusicRecordEntities _context;

        public static MusicRecordEntities GetContext()
        {
            if (_context == null)
                _context = new MusicRecordEntities();
            return _context;
        }

        public void CreateUser(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void UpdateUser(Users user)
        {
            // Состояние сущности помечается как Измененная
            _context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges(); // Сохранение измененной сущности в БД
        }
        public void RemoveUser(int idUser)
        {
            var users = _context.Users.Find(idUser); // Поиск записи пользователя по его id
            _context.Users.Remove(users); // Удаление записи найденного пользователя
            _context.SaveChanges(); // Сохранение изменений в БД
        }
        public List<Users> FiltrUsers()
        {
            return _context.Users.Where(x => x.Name.StartsWith("M") || x.Name.StartsWith("A")).ToList();
        }
    }
}
