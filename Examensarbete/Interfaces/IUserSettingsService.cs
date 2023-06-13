using Examensarbete.ViewModels;

namespace Examensarbete.Interfaces
{
    public interface IUserSettingsService
    {
        public UserWithSettings GetUserWithSettingsByPublicId(Guid userPublicId);
    }
}
