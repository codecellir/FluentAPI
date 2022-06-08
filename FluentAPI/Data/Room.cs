namespace FluentAPI.Data
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryCode { get; set; }
        public virtual Category Category { get; set; }
    }
}
