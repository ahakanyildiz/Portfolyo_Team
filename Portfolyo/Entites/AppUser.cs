namespace Portfolyo.Entites
{
    public class AppUser
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string Password { get; set; } = null!;
        public string? Email { get; set; }
        public int AppRoleId { get; set; }
        public AppRole AppRole { get; set; }
    }
}
