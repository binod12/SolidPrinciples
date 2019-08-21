using System;

namespace SolidPrinciples.ISP.With
{
  class SMSMessage : IMessage
  {
    public string Toaddress { get; set; }

    public string MessageBody { get ; set ; }

    public void send()
    {
      Console.WriteLine("Send SMS message");
    }
  }
}
