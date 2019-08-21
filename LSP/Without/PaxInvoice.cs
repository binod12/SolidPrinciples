using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LSP.Without
{
  class PaxInvoice : IInvoice
  {
    public void ProcessInvoice()
    {
      Console.WriteLine("Processing Pax Invoice");
    }

    public void PrintInvoice()
    {
      Console.WriteLine("Printing Pax Invoice");

    }
  }
}
