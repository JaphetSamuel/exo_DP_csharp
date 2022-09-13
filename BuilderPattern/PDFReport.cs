namespace BuilderPattern;

public class PDFReport: ReportBuilder
{
    public override void SetReportType()
    {
        objectReport.ReportType = "Type PDF";
    }

    public override void SetReportHeader()
    {
        objectReport.ReportHeader = "Header PDF";
    }

    public override void SetReportFooter()
    {
        objectReport.ReportFooter = "Footer PDF";
    }

    public override void SetReportContent()
    {
        objectReport.ReportContent = "Content PDF";
    }
}