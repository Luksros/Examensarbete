using Examensarbete.Interfaces;
using Examensarbete.ViewModels;

namespace Examensarbete.Services
{
    public class UserSettingsService : IUserSettingsService
    {
        private readonly IUserSettingsRepository _userSettingsRepository;
        private readonly IUserRepository _userRepository;

        public UserSettingsService(IUserSettingsRepository userSettingsRepository, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _userSettingsRepository = userSettingsRepository;
        }

        public UserWithSettings GetUserWithSettingsByPublicId(Guid userPublicId)
        {
            var user = _userRepository.GetByPublicId(userPublicId);
            var userSettings = _userSettingsRepository.GetUserSettingsByPublicId(userPublicId);

            UserWithSettings userWithSettings = new() { User = user, UserSettings = userSettings };

            return userWithSettings;
        }
    }
}
