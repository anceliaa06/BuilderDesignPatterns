using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssign
{
    internal class ExcelReportBuilder : IReportBuilder
    {
        private Report report = new Report();

        public void BuildTitle()
        {
            report.Title = "Excel Report: Sales Summary";
        }

        public void BuildContent()
        {
            report.Content = "Excel-formatted rows and columns with formulas.";
        }

        public void BuildFooter()
        {
            report.Footer = "Internal Use - Generated on " + DateTime.Now.ToShortDateString();
        }

        public Report GetReport()
        {
            return report;
        }
    }
}
