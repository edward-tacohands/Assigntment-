using System.Security.Cryptography.X509Certificates;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Xml.XPath;

namespace assignment01;

public class Courses
{
    private static List<CourseList>ListCourses { get; } = new List<CourseList>();

    public Courses(){}

    public static void AddSchoolCourses(CourseList courses){
        ListCourses.Add(courses);
    }

    public static CourseList Find(string reference){
        return ListCourses.FirstOrDefault(x => x.Reference == reference)!; //
    }
    public static void LoadJson(string path){
        string savedJson = File.ReadAllText(path);
        var options = new JsonSerializerOptions{
            PropertyNameCaseInsensitive = true
        };
        var courses = JsonSerializer.Deserialize<List<CourseList>>(savedJson, options);
        ListCourses.Clear();
        ListCourses.AddRange(courses!);
    }
    public static void SaveJson(string path){
        var options = new JsonSerializerOptions(){
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };
        string json = JsonSerializer.Serialize(ListCourses, options);
        File.WriteAllText(path, json);
    }
    public static string Show(){
        string show = "";
        foreach(var course in ListCourses){
            show += course.ToString() + "\n";
        }
        return show;
    }
    public static string TypeOfClass(string letter){
        string show = "";
        if(letter.Equals("A")){
            foreach (var course in ListCourses)
            {
                if(course.Reference.Contains("A")){
                    show += course.ToString()+"\n";
                }
            }
        } else if(letter.Equals("B")){
            foreach (var course in ListCourses)
            {
                if(course.Reference.Contains("B")){
                    show += course.ToString()+"\n";
                }
            }            
        } else{
            throw new Exception("No course was found");
        }
        return show;
    }
}