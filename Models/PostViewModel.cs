using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ForumApp.Models
{
    public class PostViewModel : AddPostViewModel
    {
        public int Id { get; set; }
    }
}
