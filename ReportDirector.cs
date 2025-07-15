using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssign
{
    public class ReportDirector
    {
        public void CreateReport(IReportBuilder builder)
        {
            builder.BuildTitle();
            builder.BuildContent();
            builder.BuildFooter();
        }
    }
}
