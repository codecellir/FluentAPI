namespace FluentAPI.Data
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
