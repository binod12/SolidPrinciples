using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Without
{
  class MiscInvoice : IInvoice
  {
    public void ProcessInvoice()
    {
      Console.WriteLine("Processing Misc Invoice");
    }

  }
}
