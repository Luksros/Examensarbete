namespace Examensarbete.Models
{
    public class UserSettings
    {
        public int Id { get; set; }
        public Guid UserPublicId { get; set; }
        public Language Language { get; set; }
        public bool DarkMode { get; set; }
        public string LocalRootFolderPath { get; set; }
    }
}
