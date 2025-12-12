using System;
using System.Threading.Tasks;

namespace Adapter_DesignPattern
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            INotificationSender email = new EmailNotification();
            email.Send("john@example.com", "Welcome to our platform!");

            // Using adapter for third-party SMS
            var smsService = new ThirdPartySmsService();
            INotificationSender sms = new SmsAdapter(smsService);

            sms.Send("+919876543210", "Your OTP is 123456");
            Console.WriteLine("--------EnD of Adapter_DesignPattern!-------------");
        }
    }
}

/* ------------
Scenario:
Your application sends notifications using your own interface INotificationSender, but a third-party SMS API uses a completely different class (ThirdPartySmsService).
Using an Adapter, we make that incompatible SMS service work with our system.

*/