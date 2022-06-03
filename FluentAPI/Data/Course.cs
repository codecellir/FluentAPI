namespace FluentAPI.Data
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PreCourseId { get; set; }
        public virtual Course PreCourse { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
