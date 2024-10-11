namespace assignment01;

public class Tutor : Person, ICourseAssign
{
    private static List<Tutor>ListTutors { get; set; } = new List<Tutor>();
     public List<CourseList> ListCourses { get; private set; } = new List<CourseList>();
    public string Expertise { get; set; } = "";

    internal Tutor(string fn, string sn, string pn, string pin, string a, string pc, string c, string e)
    {
        FirstName = fn;
        SurName = sn;
        PhoneNumber = pn;
        PersonalIdentityNumber = pin;
        Address = a;
        PostCode = pc;
        City = c;
        Expertise = e;
    }
    internal static void AddList(Tutor tutor){
        ListTutors.Add(tutor);
    }
    internal static Tutor Find(string personalIdentityNumber){
        return ListTutors.FirstOrDefault(x => x.PersonalIdentityNumber == personalIdentityNumber)!;
    }
    public virtual void AssignCourse(CourseList course){
        ListCourses.Add(course);
    }
    public static string Show(){
        string show = "";
        foreach(var tutor in ListTutors){
            show += tutor.ToString()+"\nLärare inom: ";
            foreach(var course in tutor.ListCourses){
                show += $"{course.Title} \t"; 
            }
        }
        return show;
    }

    public override string ToString()
    {
        return $"Namn: {FirstName} {SurName} - Personnummer: {PersonalIdentityNumber} \nTelefonnummer: {PhoneNumber} - Adress: {Address}, {PostCode} {City} - Kunskapsområde: {Expertise}";
    }

    void ICourseAssign.AssignCourse(CourseList course)
    {
        throw new NotImplementedException();
    }
}
