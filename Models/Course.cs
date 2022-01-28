namespace MVC.Models;

public class Course
{
        //constructor that runns everytime there is an instance ofthe class. 
        public Course(){}
        //Constructor that can fill in values from a course
    public Course(int id, string courseName, string progression, string syllabus)
    {
        this.Id= id;
        this.CourseName = courseName;
        this.Progression = progression;
        this.Syllabus = syllabus;
    }
    public int? Id { get; set; }

    public string? CourseName { get; set; }
    public string? Progression { get; set; }
    public string? Syllabus { get; set; }

    public class ViewModel{
        public IEnumerable<Course> CourseList {get; set;}
    }


}
