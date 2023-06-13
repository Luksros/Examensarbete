using Examensarbete.Models;

namespace Examensarbete.Interfaces
{
    public interface IUserSettingsRepository
    {
        public UserSettings GetUserSettingsByPublicId(Guid userPublicId);
    }
}
