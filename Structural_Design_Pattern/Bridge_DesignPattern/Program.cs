using System;
using System.Threading.Tasks;

namespace Bridge_DesignPattern
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var shortEmail = new ShortMessage(new EmailSender());
            shortEmail.SendMessage("Hello, this is a short email!");

            var longSms = new LongMessage(new SmsSender());
            longSms.SendMessage("This is a long SMS message that contains more details...");

            var shortWhatsApp = new ShortMessage(new WhatsAppSender());
            shortWhatsApp.SendMessage("Short WhatsApp message!");
            Console.WriteLine("---------END of from Bridge_DesignPattern!----------");
        }
    }
}

/* --------------
✅ Scenario

You want to send different types of messages (Short Message, Long Message).
You can send them using different platforms (Email, SMS, WhatsApp).

Two dimensions that vary independently:

1️⃣ Message Type
ShortMessage
LongMessage

2️⃣ Message Sender (Platform)
EmailSender
SmsSender
WhatsAppSender

Bridge Pattern helps you connect both independently.
The arrow (Message → IMessageSender) is the BRIDGE.
*/