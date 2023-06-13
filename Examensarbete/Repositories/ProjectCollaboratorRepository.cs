using Examensarbete.Data;
using Examensarbete.Interfaces;
using Examensarbete.Models;

namespace Examensarbete.Repositories
{
    public class ProjectCollaboratorRepository : IProjectCollaboratorRepository
    {
        private readonly alsDbContext _context;
        public ProjectCollaboratorRepository(alsDbContext context)
        {
            _context = context;
        }

        public List<User> GetCollaboratorsByProjectPublicId(Guid projectPublicId)
        {
            var collabProjects = _context.ProjectCollaborators.Where(pc => pc.ProjectPublicId == projectPublicId).ToList();
            List<User> users = new List<User>();
            foreach (var cp in collabProjects)
            {
                var user = _context.Users.FirstOrDefault(p => p.PublicId == cp.UserPublicId);
                users.Add(user);
            }
            return users;
        }

        public List<Project> GetCollabProjectsByUserPublicId(Guid userPublicId)
        {
            var collabProjects = _context.ProjectCollaborators.Where(pc => pc.UserPublicId == userPublicId).ToList();
            List<Project> projects = new List<Project>();
            foreach(var cp in collabProjects)
            {
                var project = _context.Projects.FirstOrDefault(p => p.PublicId == cp.ProjectPublicId);
                projects.Add(project);
            }
            return projects;
        }
    }
}
