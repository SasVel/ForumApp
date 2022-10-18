using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ForumApp.Constants.DataConstants.Post;

namespace ForumApp.Data.Models
{
    [Comment("Published posts")]
    public class Post
    {
        [Key]
        [Comment("Table Identification")]
        public int Id { get; set; }

        [Required]
        [Comment("Post Title")]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [Comment("Post Content")]
        [MaxLength(ContextMaxLength)]
        public string Content { get; set; } = null!;
    }
}
