using Examensarbete.Models;

namespace Examensarbete.Interfaces
{
    public interface IProjectCollaboratorRepository
    {
        public List<Project> GetCollabProjectsByUserPublicId(Guid userPublicId);
        public List<User> GetCollaboratorsByProjectPublicId(Guid projectPublicId);   
    }
}
