namespace BuilderPattern;

public class ExcelReport: ReportBuilder
{
    public override void SetReportType()
    {
        objectReport.ReportType = "Type Excel";
    }

    public override void SetReportHeader()
    {
        objectReport.ReportHeader = "en-tete excel";
    }

    public override void SetReportFooter()
    {
        objectReport.ReportFooter = "Excel footer";
    }

    public override void SetReportContent()
    {
        objectReport.ReportContent = "Excel content";
    }
}