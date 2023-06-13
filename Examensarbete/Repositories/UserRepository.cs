using Examensarbete.Data;
using Examensarbete.Interfaces;
using Examensarbete.Models;

namespace Examensarbete.Repositories
{
    public class UserRepository : IUserRepository
    {
        //private List<User> users;
        private readonly alsDbContext _context;

        public UserRepository(alsDbContext context)
        {
            //users = new List<User>();
            _context = context;
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public User GetByPublicId(Guid publicId)
        {
            return _context.Users.FirstOrDefault(u => u.PublicId == publicId);
        }

        public User GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }

        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            // Assuming user.Id is unique, find the user by Id and update its properties
            User existingUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.PublicId = user.PublicId;
                existingUser.Username = user.Username;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
            }
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
    }
}
