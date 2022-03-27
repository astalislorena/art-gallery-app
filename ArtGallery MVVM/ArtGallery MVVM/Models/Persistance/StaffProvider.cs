using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVP.Models.Persistance
{
    public class StaffProvider
    {
        private readonly ArtGalleryDbContext _db;

        public StaffProvider(ArtGalleryDbContext dbContext)
        {
            _db = dbContext;
        }
        public IQueryable<User> QueryPaitings() => _db.Users.AsQueryable();

        public User AddUser(string firstName, string lastName, string email, string password)
        {
            User user = new(firstName, lastName, email, password);
            _db.Users.Add(user);
            _db.SaveChanges();
            return user;
        }

        public User UpdateUser(string firstName, string lastName, string email, string password)
        {
            User correspUser = _db.Users.SingleOrDefault(p => p.Email == email);
            if (correspUser == null)
            {
                throw new Exception("User not found!");
            }
            correspUser.FirstName = firstName;
            correspUser.LastName = lastName;
            correspUser.Password = password;
            _db.SaveChanges();
            return correspUser;
        }

        public User GetUserByEmail(string email)
        {
            try
            {
                return _db.Users.SingleOrDefault(p => p.Email == email);
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting user: " + ex.ToString());
            }
        }

        public void DeleteUserByEmail(string email)
        {
            try
            {
                _db.Users.Remove(GetUserByEmail(email));
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting user: " + ex.ToString());
            }
        }
    }
}
