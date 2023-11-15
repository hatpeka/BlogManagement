using System.ComponentModel.DataAnnotations;

namespace BlogManagement.Models
{
    public class Profile
    {
        [Key]
        public int ProfileId { get; private set; }
        [Required]
        public int UserId { get; private set; }
        [StringLength(500)]
        public string Bio { get; set; } 
        public DateTime JoinDate { get; set; }
        public User User { get; private set; }
        public Profile(int userId)
        {
            this.UserId = userId;
            JoinDate = DateTime.Now;
        }
    }
}
