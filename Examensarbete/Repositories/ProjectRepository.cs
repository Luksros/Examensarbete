using Examensarbete.Data;
using Examensarbete.Interfaces;
using Examensarbete.Models;

namespace Examensarbete.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        //private List<Project> projects;
        private readonly alsDbContext _context;


        public ProjectRepository(alsDbContext context)
        {
            //projects = new List<Project>();
            _context = context;
        }

        public Project GetById(int id)
        {
            return _context.Projects.FirstOrDefault(p => p.Id == id);
        }

        public Project GetByPublicId(Guid publicId)
        {
            return _context.Projects.FirstOrDefault(p => p.PublicId == publicId);
        }

        public IEnumerable<Project> GetByOwnerPublicId(Guid ownerPublicId)
        {
            return _context.Projects.Where(p => p.OwnerPublicId == ownerPublicId);
        }

        public void Add(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void Update(Project project)
        {
            // Assuming project.Id is unique, find the project by Id and update its properties
            Project existingProject = _context.Projects.FirstOrDefault(p => p.Id == project.Id);
            if (existingProject != null)
            {
                existingProject.PublicId = project.PublicId;
                existingProject.ProjectFileName = project.ProjectFileName;
                existingProject.CreatedDate = project.CreatedDate;
                existingProject.LastEditedDate = project.LastEditedDate;
                existingProject.OwnerPublicId = project.OwnerPublicId;
                //existingProject.Collaborators = project.Collaborators;
                existingProject.DriveItemId = project.DriveItemId;
                existingProject.FileSize = project.FileSize;
            }
            _context.SaveChanges();
        }

        public void Delete(Project project)
        {
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }

        public IEnumerable<Project> GetAll()
        {
            return _context.Projects;
        }
    }
}
