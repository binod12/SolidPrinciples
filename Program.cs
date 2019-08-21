

using System.Collections.Generic;

namespace SolidPrinciples
{
  class Program
  {
    static void Main(string[] args)
    {
      //Without SRP
      SRP.Without.Invoice.PrintInvoice();
      SRP.Without.Invoice.SendEmail();

      //With SRP
      SRP.With.Invoice.PrintInvoice();
      SRP.With.EmailSender.SendEmail();


      ////Without OCP
      OCP.Without.Invoice.ProcessInvoice(OCP.Without.InvoiceType.Pax);
      OCP.Without.Invoice.ProcessInvoice(OCP.Without.InvoiceType.Cargo);
      OCP.Without.Invoice.ProcessInvoice(OCP.Without.InvoiceType.Misc);


      //With OCP
      //If required a new Invoice Type, it can be created as a new class and 
      //can implement the same method of Invoice or altogether can have a new interface
      //and implement the new interface like as under:
      new OCP.With.PaxInvoice().ProcessInvoice();
      new OCP.With.CargoInvoice().ProcessInvoice();
      new OCP.With.MiscInvoice().ProcessInvoice();
      new OCP.With.UatpInvoice().ProcessInvoice();

      //Without LSP - it will fail
      //Runtime type switching
      LSP.Without.PaxInvoice paxInvoice = new LSP.Without.PaxInvoice();
      var miscInvoice = paxInvoice as LSP.Without.PaxInvoice;
      miscInvoice.PrintInvoice();

      //With LSP - Just remove the method PrintInvoice from PaxInvoice from
     

    }
  }
}
