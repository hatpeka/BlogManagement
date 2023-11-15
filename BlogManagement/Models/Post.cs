using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogManagement.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public User Author { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(10000)]
        public string Content { get; set; }
        public DateTime TimePublished { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Rating> Rating { get; set; }

        public Post()
        {
        }
        public Post(User author, string title, string content)
        {
            this.Author = author;
            this.Title = title;
            this.Content = content;
            this.TimePublished = DateTime.Now;
            this.Comment = new List<Comment>();
            this.Rating = new List<Rating>();
        }
    }
}
