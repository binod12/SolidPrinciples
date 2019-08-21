/// <summary>
/// This section will show how it violates the Open-Closed-Principle (OCP)
/// </summary>
namespace SolidPrinciples.OCP.With
{
  class CargoInvoice : IInvoice
  {
    public void ProcessInvoice()
    {
      System.Console.WriteLine("Processing CargoInvoice");
    }
  }
}
