namespace FluentAPI.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string DisplayName { get; set; }
        public string NationalCode { get; set; }
        public int Age { get; set; }
        public float Score { get; set; }
        public bool Active { get; set; }
        public string CourseName { get; set; }
        public string Test { get; }
        public int GradeId { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
