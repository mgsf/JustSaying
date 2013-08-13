using System;
namespace JustEat.Simples.NotificationStack.Messaging.Messages.OrderPlacement
{
    public class OrderPlacementRequested : Message
    {
        public OrderPlacementRequested(Guid orderId)
        {
            OrderId = orderId;
        }

        public Guid OrderId { get; private set; }
    }
}