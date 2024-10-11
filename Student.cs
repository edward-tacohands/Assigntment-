namespace assignment01;

public class Student : Person, ICourseAssign
{   
    public CourseList? ListCourse { get; private set; }
    private static List<Student>ListStudents { get; set; } = new();

    internal Student(string fn, string sn, string pn, string pin, string a, string pc, string c){
        FirstName = fn;
        SurName = sn;
        PhoneNumber = pn;
        PersonalIdentityNumber = pin;
        Address = a;
        PostCode = pc;
        City = c;
    }
    internal static void AddList(Student student){
        ListStudents.Add(student);
    }
    internal static Student Find(string personalIdentityNumber){
        return ListStudents.FirstOrDefault(x => x.PersonalIdentityNumber == personalIdentityNumber)!;
    }
    public void AssignCourse(CourseList course){
        ListCourse = course;
    }
    public static string Show(){
        string show = "";
        foreach(var student in ListStudents){
            show += student.ToString() + "\n";
        }
        return show;
    }
    public override string ToString()
    {
        return $"Namn: {FirstName} {SurName} - Personnummer: {PersonalIdentityNumber} \nTelefonnummer: {PhoneNumber} - Adress: {Address}, {PostCode} {City} \nStuderar: {ListCourse?.Title}";
    }

    void ICourseAssign.AssignCourse(CourseList course)
    {
        throw new NotImplementedException();
    }
}