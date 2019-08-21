using System;

namespace SolidPrinciples.SRP.Without
{
  static class Invoice
  {
    public static void PrintInvoice()
    {
      Console.WriteLine("Printing Invoices");
    }

    //The following method can be implemented in another class in order to
    //follow SRP - Single responsibility Principle
    public static void SendEmail()
    {
      Console.WriteLine("Sending email");
    }
  }
}
