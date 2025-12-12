namespace Builder_DesignPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Manual custom notification
            var customMsg = new NotificationBuilder()
                .To("user@example.com")
                .WithTitle("System Update")
                .WithBody("Your report is ready.")
                .ScheduleAt(DateTime.Now.AddMinutes(10))
                .Build();

            Console.WriteLine("Custom Message:");
            Console.WriteLine(customMsg);
            Console.WriteLine("-----END of from Builder_DesignPattern!------------");
        }
    }
}


