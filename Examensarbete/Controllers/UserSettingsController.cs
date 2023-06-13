using Examensarbete.Interfaces;
using Examensarbete.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Examensarbete.Controllers
{
    public class UserSettingsController : Controller
    {
        private readonly IUserSettingsRepository _userSettingsRepository;
        private readonly IUserSettingsService _userSettingsService;

        public UserSettingsController(IUserSettingsRepository userSettingsRepository, IUserSettingsService userSettingsService)
        {
            _userSettingsRepository = userSettingsRepository;
            _userSettingsService = userSettingsService;
        }

        public IActionResult Index()
        {
            var model = _userSettingsService.GetUserWithSettingsByPublicId(Guid.Parse("34cfd964-7c00-433b-b6b1-f0c83ebe0fc4"));
            return View(model);
        }
    }
}
