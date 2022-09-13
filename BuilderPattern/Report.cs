namespace BuilderPattern;

public class Report
{
    public string ReportType { get; set; }
    public string ReportHeader { get; set; }
    public string  ReportFooter { get; set; }
    public string  ReportContent { get; set; }

    public void DisplayReport()
    {
        Console.WriteLine("type" + ReportType);
        Console.WriteLine("header" + ReportHeader);
        Console.WriteLine("footer" + ReportFooter);
        Console.WriteLine("content" + ReportContent);
    }
}