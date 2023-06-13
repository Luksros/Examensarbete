using Examensarbete.Models;

namespace Examensarbete.ViewModels
{
    public class UserProjects
    {
        public User User { get; set; }
        public List<Project> Projects { get; set; }
        public List<Project> CollabProjects { get; set; }
    }
}
