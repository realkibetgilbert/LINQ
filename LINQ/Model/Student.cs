namespace LINQ.Model
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Grade { get; set; }

        public Student(long id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Grade: {Grade}";
        }
    }

}
