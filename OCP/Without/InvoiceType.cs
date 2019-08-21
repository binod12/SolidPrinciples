using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// This section will show how it violates the Open-Closed-Principle (OCP)
/// </summary>
namespace SolidPrinciples.OCP.Without
{
  enum InvoiceType
  {
    Pax = 1,
    Cargo = 2,
    Misc = 3
  }
}
