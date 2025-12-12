namespace AbstractFactory_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ServiceFactory factory;

            // Email Factory
            factory = new EmailServiceFactory();
            var emailNotify = factory.CreateNotification();
            var emailLogger = factory.CreateLogger();

            emailNotify.Send("Welcome!");
            emailLogger.Log("Welcome email logged.");

            Console.WriteLine("----------------");

            // SMS Factory
            factory = new SmsServiceFactory();
            var smsNotify = factory.CreateNotification();
            var smsLogger = factory.CreateLogger();

            smsNotify.Send("Your OTP is 1234");
            smsLogger.Log("OTP SMS logged.");

            Console.WriteLine("-----END of AbstractFactory_DesignPattern!-------");
        }
    }
}