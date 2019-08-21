using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.ISP.Without
{
  interface IMessage
  {
    string Toaddress { get; set; }
    string Subject { get; set; }
    string MessageBody { get; set; }
    void send();
  }
}
