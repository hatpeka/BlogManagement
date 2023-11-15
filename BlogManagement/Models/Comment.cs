using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogManagement.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; private set; }
        [ForeignKey("Commantator")]
        public int UserId { get; set; }
        public User Commentator { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post {  get; set; }
        [StringLength(255)]
        public string Content { get; set; }
        public DateTime CommentTime { get; set; }
    }
}
