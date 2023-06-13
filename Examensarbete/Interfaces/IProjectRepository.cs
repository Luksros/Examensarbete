using Examensarbete.Models;

namespace Examensarbete.Interfaces
{
    public interface IProjectRepository
    {
        Project GetById(int id);
        Project GetByPublicId(Guid publicId);
        IEnumerable<Project> GetByOwnerPublicId(Guid ownerPublicId);
        void Add(Project project);
        void Update(Project project);
        void Delete(Project project);
        IEnumerable<Project> GetAll();
    }
}
