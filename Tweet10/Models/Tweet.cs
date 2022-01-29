using System.ComponentModel.DataAnnotations;

namespace Tweet10.Models
{
    public class Tweet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime createdDateTime { get; set; } = DateTime.Now;




    }
}
