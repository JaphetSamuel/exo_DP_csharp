namespace BuilderPattern;

public abstract class ReportBuilder
{
    protected Report objectReport;

    public abstract void SetReportType();
    public abstract void SetReportHeader();
    public abstract void SetReportFooter();
    public abstract void SetReportContent();

    public void CreateReport()
    {
        objectReport = new Report();
    }

    public Report GetReport()
    {
        return objectReport;
    }
}