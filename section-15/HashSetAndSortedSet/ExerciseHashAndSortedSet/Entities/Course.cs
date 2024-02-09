namespace ExerciseHashAndSortedSet.Entities;
internal class Course
{
    public int StudentId { get; set; }

    public Course(int studentId)
    {
        StudentId = studentId;
    }

    public override int GetHashCode()
    {
        return StudentId.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Course))
        {
            return false;
        }
        Course other = obj as Course;
        return StudentId.Equals(other.StudentId);
    }
}
