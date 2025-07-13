using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeFlick.Core.Interfaces
{
    public interface IPdfGenerator
    {
        byte[] GeneratePdfFromHtml(string htmlContent);
    }
}
