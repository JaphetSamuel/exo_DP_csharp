﻿namespace BuilderPattern;

public class ReportDirector
{
    public Report MakeReport(ReportBuilder reportBuilder)
    {
        reportBuilder.CreateReport();
        reportBuilder.SetReportType();
        reportBuilder.SetReportHeader();
        reportBuilder.SetReportFooter();
        reportBuilder.SetReportContent();
        return reportBuilder.GetReport();
    }
}