using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public interface ISendMessage
    {
        void sendMessage(Message m);

        void sendMessageToAll(string[] to, Message m);
    }
}
