using System;

namespace OrderApp
{
    // Delegate Declaration
    public delegate void OrderPlacedHandler(Order order);

    public class OrderProcessor
    {
        // Event Declaration
        public event OrderPlacedHandler OnOrderPlaced;

        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Order Placed: {order.OrderId}");

            try
            {
                // Null-safe event invocation
                OnOrderPlaced?.Invoke(order);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while sending notifications: {ex.Message}");
            }
        }
    }
}
