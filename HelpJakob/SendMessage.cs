using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    class SendMessage
    {
        // The Enums represent the types of messages there can be.
        public enum messageTypes { Smtp, VMessage }
        public void SendNewMessage(messageTypes type, Message newMessage)
        {
            //This is thought as the managers way to find out what type of message is being deployed. 
            
            if (type.Equals(messageTypes.Smtp))
            {
                Smtp smtp = new Smtp();
                ((ISendMessage)smtp).sendMessage(newMessage);
            }
            if (type.Equals(messageTypes.VMessage))
            {
                VMessage vMessage = new VMessage();
                ((ISendMessage)vMessage).sendMessage(newMessage);
            }
        }
        public void SendNewMessageAll(messageTypes mT, string[] to, Message newMessage)
        {
            if (mT.Equals(messageTypes.Smtp))
            {
                Smtp smtp = new Smtp();
                ((ISendMessage)smtp).sendMessageToAll(newMessage.To.Split(","), newMessage);
            }
            if (mT.Equals(messageTypes.VMessage))
            {
                VMessage vMessage = new VMessage();
                ((ISendMessage)vMessage).sendMessageToAll(newMessage.To.Split(","), newMessage);
            }
        }
    }
}
