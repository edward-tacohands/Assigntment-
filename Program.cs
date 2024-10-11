using System.Globalization;

namespace assignment01;

class Program
{
    static void Main()
    {
        System.Console.WriteLine();
        Admin admin = new Admin("Romeo", "Montague", "07534425322", "15790812-5634", "Montague Drive 451", "431 24", "Verona", "Kärlek", new DateTime(1597, 06, 10));
        System.Console.WriteLine($"{admin}\n");

        admin.AddCourse("110A", "Matematik 1", 120, new DateTime(2025, 01, 03));
        admin.AddCourse("110B", "Matematik 1 Distans", 120, new DateTime(2025, 01, 03));
        admin.AddCourse("210A", "Programering 1", 80, new DateTime(2025, 01, 03));
        admin.AddCourse("210B", "Programering 1 Distans", 80, new DateTime(2025, 01, 03));
        System.Console.WriteLine("Kurser som erbjuds på denna skola: ");
        var showCourses = Courses.Show();
        System.Console.WriteLine(showCourses);

        var path = string.Concat(Environment.CurrentDirectory, "/data/courses.json");
        Courses.SaveJson(path);
        Courses.LoadJson(path);

        var showCourses2 = Courses.Show();
        System.Console.WriteLine(showCourses2);

        System.Console.WriteLine("Lektioner på plats:");
        try{
            string a = Courses.TypeOfClass("A");
            System.Console.WriteLine(a);
        }catch(Exception ex){
            System.Console.WriteLine(ex.Message);
        }
        System.Console.WriteLine("Lektioner på distans: ");
        try{
            string b = Courses.TypeOfClass("B");
            System.Console.WriteLine(b);
        }catch(Exception ex){
            System.Console.WriteLine(ex.Message);
        }

        admin.AddStudent("Olga", "Babkina", "0745277543", "20040612-1000", "Solgatan 41", "215 54", "Malmlö");
        admin.AddStudent("Joachim", "Cook", "0753245331", "19930712-5422", "Rymdvägen 66", "123 45", "Berlin");
        
        try{
            admin.AssignCourseStudent("20040612-1000", "110A");
        }catch(Exception ex){
            System.Console.WriteLine(ex.Message);
        }
        try{
            admin.AssignCourseStudent("19930712-5422", "210B");
        }catch(Exception ex){
            System.Console.WriteLine(ex.Message);
        }

        System.Console.WriteLine("Elever på skolan: ");
        string showStudents = Student.Show();
        System.Console.WriteLine(showStudents);
        
        admin.AddTutor("Kenny", "Väst", "070643985", "19770608-4969", "Hollywoodvägen 6", "683 53", "Los Angeles", "Matematik");
        admin.AssignCourseTutor("19770608-4969", "110A");
        admin.AssignCourseTutor("19770608-4969", "110B");
        System.Console.WriteLine("Lärare på skolan: ");
        string showTutors = Tutor.Show();
        System.Console.WriteLine(showTutors+"\n");

        admin.AddHead("Bruce", "Lee", "0743343433", "19450923-5678", "Ladies Market 44", "123 12", "Hong Kong", "Matematik", new DateTime(1999, 10, 11));
        admin.AssignCourseHead("19450923-5678", "110A");
        admin.AssignCourseHead("19450923-5678", "110B");
        admin.AssignCourseHead("19450923-5678", "210A");
        admin.AssignCourseHead("19450923-5678", "210B");
        System.Console.WriteLine("Kursledare på skolan: ");
        string showHead = HeadOfEducation.Show();
        System.Console.WriteLine(showHead); 

    }
}
