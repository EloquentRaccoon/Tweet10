using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tweet10.Areas.Identity.Data;

namespace Tweet10.Models
{
    public class Tweet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        
        public string? Photo { get; set; }
       
        public string? Video { get; set; }
        
        public int Likes { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public string Username { get; set; }
        public string? UserId { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
