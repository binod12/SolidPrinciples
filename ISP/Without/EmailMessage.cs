using System;

namespace SolidPrinciples.ISP.Without
{
  class EmailMessage : IMessage
  {
    public string Toaddress { get; set; }
    public string Subject { get; set; }
    public string MessageBody { get; set; }
    public void send()
    {
      Console.WriteLine("Send Email message");
    }
  }
}
