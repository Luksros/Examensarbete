namespace Examensarbete.Models
{
    public class Project
    {
        public int Id { get; set; }
        public Guid PublicId { get; set; }
        public string ProjectFileName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastEditedDate { get; set; }
        public Guid OwnerPublicId { get; set; }
        //public List<User> Collaborators { get; set; }
        public string DriveItemId { get; set; }
        public int FileSize { get; set; }
    }
}
