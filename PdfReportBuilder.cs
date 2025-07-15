using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssign
{
    public class PdfReportBuilder : IReportBuilder
    {
        private Report report = new Report();
        public void BuildTitle()
        {
            report.Title = "PDF Report: Sales Summary";
        }

        public void BuildContent()
        {
            report.Content = "PDF-formatted content with tables and charts.";
        }

        public void BuildFooter()
        {
            report.Footer = "Confidential - Generated on " + DateTime.Now.ToShortDateString();
        }

        public Report GetReport()
        {
            return report;
        }

    }
}
