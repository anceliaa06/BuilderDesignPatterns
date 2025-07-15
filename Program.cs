namespace BuilderAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a director object 
            var director = new ReportDirector();

            //pdf report generation
            IReportBuilder pdfBuilder = new PdfReportBuilder();
            director.CreateReport(pdfBuilder);
            Report pdfReport = pdfBuilder.GetReport();
            pdfReport.Display("PDF");
            Console.WriteLine();

            //excel report generation
            IReportBuilder excelBuilder = new ExcelReportBuilder();
            director.CreateReport(excelBuilder);
            Report excelReport = excelBuilder.GetReport();
            excelReport.Display("Excel");
            Console.WriteLine();


        }
    }
}
