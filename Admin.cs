namespace assignment01;

public class Admin : HeadOfEducation
{
    public Admin(string fn, string sn, string pn, string pin, string a, string pc, string c, string e, DateTime ed) : base(fn, sn, pn, pin, a, pc, c, e, ed)
    {}
    public void AddCourse(string r, string t, int ld, DateTime sd){
        Courses.AddSchoolCourses(new CourseList(r, t, ld, sd));
    }
    public void AddHead(string fn, string sn, string pn, string pin, string a, string pc, string c, string e, DateTime ed){
        HeadOfEducation newHead = new HeadOfEducation(fn, sn, pn, pin, a, pc, c, e, ed);
        HeadOfEducation.AddList(newHead);
    }
    public void AddStudent(string fn, string sn, string pn, string pin, string a, string pc, string c){
        Student newStudent= new Student(fn, sn, pn, pin, a, pc, c);
        Student.AddList(newStudent);
    }
    public void AddTutor(string fn, string sn, string pn, string pin, string a, string pc, string c, string e){
        Tutor newTutor = new Tutor(fn, sn, pn, pin, a, pc, c, e);
        Tutor.AddList(newTutor);
    }
    internal new void AssignCourse(CourseList course)
    {
        ListCourses.Add(course);
    }
    public void AssignCourseHead(string personalIdentityNumber, string courseReference){
        HeadOfEducation head = HeadOfEducation.Find(personalIdentityNumber);
        CourseList course = Courses.Find(courseReference);
        head.AssignCourse(course);
    }
    public void AssignCourseStudent(string personalIdentityNumber, string courseReference){
        Student student = Student.Find(personalIdentityNumber);
        if(student == null){
            throw new Exception($"{personalIdentityNumber} hittades inte");
        }
        CourseList course = Courses.Find(courseReference);
        if(courseReference == null){
            throw new Exception($"{courseReference} hittades inte.");
        }
        student.AssignCourse(course);
    }
    public void AssignCourseTutor(string personalIdentityNumber, string courseReference){
        Tutor tutor = Tutor.Find(personalIdentityNumber);
        CourseList course = Courses.Find(courseReference);
        tutor.AssignCourse(course);
    }
}
