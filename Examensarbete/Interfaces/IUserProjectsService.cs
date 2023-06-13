using Examensarbete.ViewModels;

namespace Examensarbete.Interfaces
{
    public interface IUserProjectsService
    {
        public UserProjects GetUserAndProjectsByUserId(int userId);
        public ProjectDetails GetProjectDetails(Guid projectPublicId);
    }
}
