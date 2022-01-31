namespace Tweet10.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual Tweet tweet { get; set; }
       
    }
}
