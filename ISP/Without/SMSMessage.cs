using System;

namespace SolidPrinciples.ISP.Without
{
  class SMSMessage : IMessage
  {
    public string Toaddress { get; set; }

    //This is violation of ISP
    public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string MessageBody { get ; set ; }

    public void send()
    {
      Console.WriteLine("Send SMS message");
    }
  }
}
