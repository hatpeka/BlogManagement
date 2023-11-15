using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogManagement.Models
{
    public class Rating
    {
        [Key]
        public int RatingId { get; private set; }
        [ForeignKey("RatePerson")]
        public int UserId { get; set; }
        public User RatePerson { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
        public enum RatingValue { One = 1, Two = 2, Three = 3, Four = 4, Five = 5 }
        public RatingValue Value { get; set; }
    }
}
