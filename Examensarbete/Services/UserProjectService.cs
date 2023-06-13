using Examensarbete.Interfaces;
using Examensarbete.Repositories;
using Examensarbete.ViewModels;

namespace Examensarbete.Services
{
    public class UserProjectService : IUserProjectsService
    {
        private readonly IUserRepository _userRepository;
        private readonly IProjectRepository _projectRepository;

        public UserProjectService(IUserRepository userRepository, IProjectRepository projectRepository)
        {
            _userRepository = userRepository;
            _projectRepository = projectRepository;
        }
        public UserProjects GetUserAndProjectsByUserId(int userId)
        {
            var user = _userRepository.GetById(userId);
            var projects = _projectRepository.GetByOwnerPublicId(user.PublicId).ToList();

            var model = new UserProjects() { User = user, Projects = projects };

            return model;
        }

        public ProjectDetails GetProjectDetails(Guid projectPublicId)
        {
            var project = _projectRepository.GetByPublicId(projectPublicId);
            var user = _userRepository.GetByPublicId(project.OwnerPublicId);

            var model = new ProjectDetails() { User = user, Project = project };

            return model;
        }
    }
}