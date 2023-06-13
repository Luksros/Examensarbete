using Examensarbete.Data;
using Examensarbete.Interfaces;
using Examensarbete.Models;

namespace Examensarbete.Repositories
{
    public class UserSettingsRepository : IUserSettingsRepository
    {
        private readonly alsDbContext _context;
        public UserSettingsRepository(alsDbContext context)
        {
            _context = context;
        }

        public UserSettings GetUserSettingsByPublicId(Guid userPublicId)
        {
            return _context.UserSettings.FirstOrDefault(us => us.UserPublicId == userPublicId);
        }
    }
}
