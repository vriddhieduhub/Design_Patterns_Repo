using System;

namespace Factory_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            INotification notify1 = NotificationFactory.Create("email");
            notify1.Send("Hello via Email!");

            INotification notify2 = NotificationFactory.Create("sms");
            notify2.Send("Hello via SMS!");
             Console.WriteLine("-------------END of Factory_DesignPattern! -----------");

        }
    }
}