using OrderApp.Services;

namespace OrderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Processor
            OrderProcessor processor = new OrderProcessor();

            // Create Subscriber Services
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            LoggerService loggerService = new LoggerService();

            // Subscribe Services to Event
            processor.OnOrderPlaced += emailService.SendEmail;
            processor.OnOrderPlaced += smsService.SendSMS;
            processor.OnOrderPlaced += loggerService.LogOrder;

            // Create Order
            Order order = new Order
            {
                OrderId = 101,
                CustomerName = "Praveen",
                Amount = 1500
            };

            // Process Order
            processor.ProcessOrder(order);

            Console.WriteLine();

            // Unsubscribe SMS Service (Bonus)
            processor.OnOrderPlaced -= smsService.SendSMS;

            Console.WriteLine("After SMS Unsubscribed:");

            Order order2 = new Order
            {
                OrderId = 102,
                CustomerName = "Rahul",
                Amount = 2500
            };

            processor.ProcessOrder(order2);

            Console.ReadKey();
        }
    }
}