using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssign
{
    public interface IReportBuilder
    {
        void BuildTitle();
        void BuildContent();
        void BuildFooter();
        Report GetReport();
    }
}
