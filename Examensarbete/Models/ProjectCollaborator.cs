namespace Examensarbete.Models
{
    public class ProjectCollaborator
    {
        public int Id { get; set; }
        public Guid UserPublicId { get; set; }
        public Guid ProjectPublicId { get; set; }   
    }
}
