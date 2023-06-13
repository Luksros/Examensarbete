using Examensarbete.Models;

namespace Examensarbete.Interfaces
{
    public interface IUserRepository
    {
        User GetById(int id);
        User GetByPublicId(Guid publicId);
        User GetByUsername(string username);
        User GetByEmail(string email);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        IEnumerable<User> GetAll();
    }
}
