using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Models
{
    public class User
    {
        [Key]
        public int UserId { get; private set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Password { get; set; }
        public enum Role { Admin, Client }
        public Role UserRole { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Rating> Rating { get; set; }


        [Required]
        public Profile Profile { get; set; }

        public User(string name, string email, string password, Role role)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.UserRole = role;
            this.Comment = new List<Comment>();
            this.Rating = new List<Rating>();
        }
        public void SetProfile(Profile profile)
        {
            this.Profile = profile;
        }
        private User()
        {
        }
    }
}
