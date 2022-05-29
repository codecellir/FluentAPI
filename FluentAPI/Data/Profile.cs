namespace FluentAPI.Data
{
    public class Profile
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
