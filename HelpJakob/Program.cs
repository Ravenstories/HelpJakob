using System;
using System.Collections.Generic;

namespace HelpJakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Message newMessage = new Message("to", "from", "body", "subject", "cc");

            ConvertToHTML convert = new ConvertToHTML();
            convert.ConvertBodyToHTML(newMessage.Body);


            SendMessage sendMessage = new SendMessage();
            sendMessage.SendNewMessage(SendMessage.messageTypes.Smtp, newMessage);




    }

}
}
