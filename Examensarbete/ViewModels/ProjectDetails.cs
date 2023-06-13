using Examensarbete.Models;

namespace Examensarbete.ViewModels
{
    public class ProjectDetails
    {
        public User User { get; set; }
        public Project Project { get; set; }
        public List<User> Collaborators { get; set; }
    }
}
