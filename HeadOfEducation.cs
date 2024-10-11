namespace assignment01;

public class HeadOfEducation : Tutor
{   
    private static List<HeadOfEducation>ListHead { get; set; } = new List<HeadOfEducation>();
    public DateTime EmploymentDate { get; set; }
    internal HeadOfEducation(string fn, string sn, string pn, string pin, string a, string pc, string c, string e, DateTime ed) : base(fn, sn, pn, pin, a, pc, c, e)
    {
        EmploymentDate = ed;
    }

    internal static void AddList(HeadOfEducation head){
        ListHead.Add(head);
    }
    internal new static HeadOfEducation Find(string personalIdentityNumber){
        return ListHead.FirstOrDefault(x => x.PersonalIdentityNumber == personalIdentityNumber)!;
    }
    public override void AssignCourse(CourseList course){
        ListCourses.Add(course);
    }
    public new static string Show(){
        string show = "";
        foreach(var head in ListHead){
            show += head.ToString()+"\nAnsvarig inom: ";
            foreach(var course in head.ListCourses){
                show += $"{course.Title} \t"; 
            }
        }
        return show;
    }
        public override string ToString()
    {
        return $"Namn: {FirstName} {SurName} - Personnummer: {PersonalIdentityNumber} \nTelefonnummer: {PhoneNumber} - Adress: {Address}, {PostCode} {City}  \nKunskapsområde: {Expertise} - Anställningsdatum: {EmploymentDate}";
    }
}
