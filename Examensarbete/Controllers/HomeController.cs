using Examensarbete.Interfaces;
using Examensarbete.Models;
using Examensarbete.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Examensarbete.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly UserRepository _userRepo;
        //private readonly ProjectRepository _projectRepo;
        private readonly IUserProjectsService _userProjectsService;
        private readonly IProjectCollaboratorRepository _projectCollaboratorRepository;

        public HomeController(ILogger<HomeController> logger, IUserProjectsService userProjectsService, IProjectCollaboratorRepository projectCollaboratorRepository)
        {
            _logger = logger;
            _userProjectsService = userProjectsService;
            _projectCollaboratorRepository = projectCollaboratorRepository;
        }

        public IActionResult Index()
        {
            var model = _userProjectsService.GetUserAndProjectsByUserId(1);
            model.CollabProjects = _projectCollaboratorRepository.GetCollabProjectsByUserPublicId(Guid.Parse("34CFD964-7C00-433B-B6B1-F0C83EBE0FC4"));

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}