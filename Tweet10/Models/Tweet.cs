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
        public DateTime createdDateTime { get; set; } = DateTime.Now;
        public virtual User User { get; set; }
        public string? UserId { get; set; }

    }
}
