namespace assignment01;

public class CourseList
{
    public string Reference { get; set; } = "";
    public string Title { get; set; } = "";
    public int LengthDays { get; set; }
    public DateTime StartingDate { get; set; }
    public DateTime FinishingDate { get; set; }

    public CourseList() {}
    internal CourseList(string r, string t, int ld, DateTime sd){
        Reference = r;
        Title = t;
        LengthDays = ld;
        StartingDate = sd;
        FinishingDate = StartingDate.AddDays(LengthDays);
    }

    public override string ToString()
    {
        return $"Kursreferens: {Reference} - Titel: {Title} - Längd(dagar): {LengthDays} - Startdatum: {StartingDate.ToShortDateString()} Slutdatum: {FinishingDate.ToShortDateString()}";
    }

}