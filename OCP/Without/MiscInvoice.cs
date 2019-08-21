using System;

/// <summary>
/// This section will show how it violates the Open-Closed-Principle (OCP)
/// </summary>
namespace SolidPrinciples.OCP.Without
{
  class MiscInvoice
  {
    public static void Process()
    {
      Console.WriteLine("Processing Misc Invoices");
    }
  }
}
