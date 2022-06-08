namespace FluentAPI.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
