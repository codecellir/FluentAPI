namespace FluentAPI.Data
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
