namespace SolidPrinciples.ISP.With
{
  interface IEmailMessage
  {
    string Subject { get; set; }

  }

  interface IMessage
  {
    string Toaddress { get; set; }
    string MessageBody { get; set; }
    void send();
  }
}
