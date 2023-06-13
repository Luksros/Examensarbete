using Examensarbete.Interfaces;
using Examensarbete.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examensarbete.Controllers
{
    public class ProjectController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly IProjectRepository _projectRepository;
        private readonly IUserProjectsService _userProjectsService;
        private readonly IProjectCollaboratorRepository _projectCollaboratorRepository;

        public ProjectController(IProjectRepository projectRepository, IUserProjectsService userProjectsService, IProjectCollaboratorRepository projectCollaboratorRepository)
        {
            _projectRepository = projectRepository;
            _userProjectsService = userProjectsService;
            _projectCollaboratorRepository = projectCollaboratorRepository;
        }
        public IActionResult ProjectListItem(Project project)
        {
            return PartialView(project);
        }

        public IActionResult _ProjectDetails(Guid projectPublicId)
        {
            var model = _userProjectsService.GetProjectDetails(projectPublicId);
            model.Collaborators = _projectCollaboratorRepository.GetCollaboratorsByProjectPublicId(projectPublicId);
            return PartialView(model);
        }
    }
}
