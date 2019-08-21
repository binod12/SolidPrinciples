/// <summary>
/// This section will show how it violates the Open-Closed-Principle (OCP)
/// </summary>
namespace SolidPrinciples.OCP.Without
{
  class Invoice
  {

    //In the following implementation, if a new invoice type is added, the current class 
    //will be changed, so it will violate the Open-Closed Principle
    public static void ProcessInvoice(InvoiceType invoiceType)
    {
      switch (invoiceType)
      {
        case InvoiceType.Pax:
          PaxInvoice.Process();
          break;
        case InvoiceType.Cargo:
          CargoInvoice.Process();
          break;
        case InvoiceType.Misc:
          MiscInvoice.Process();
          break;
        default:
          break;
      }
    }
  }
}
