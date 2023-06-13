namespace Examensarbete.Models
{
    public class User
    {
        public int Id { get; set; }
        public Guid PublicId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
