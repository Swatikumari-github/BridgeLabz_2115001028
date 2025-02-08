//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Inheritance
//{
   
//    class Program
//    {
//        static void Main()
//        {
//            Order order = new Order("ORD123", "2024-02-01");
//            ShippedOrder shippedOrder = new ShippedOrder("ORD124", "2024-02-02", "TRK56789");
//            DeliveredOrder deliveredOrder = new DeliveredOrder("ORD125", "2024-02-03", "TRK98765", "2024-02-05");

//            Console.WriteLine(order.GetOrderStatus());
//            Console.WriteLine(shippedOrder.GetOrderStatus());
//            Console.WriteLine(deliveredOrder.GetOrderStatus());
//        }
//    }

//    class Order
//    {
//        protected string OrderId;
//        protected string OrderDate;

//        public Order(string orderId, string orderDate)
//        {
//            OrderId = orderId;
//            OrderDate = orderDate;
//        }

//        public virtual string GetOrderStatus()
//        {
//            return $"Order placed on {OrderDate}";
//        }
//    }

//    class ShippedOrder : Order
//    {
//        protected string TrackingNumber;

//        public ShippedOrder(string orderId, string orderDate, string trackingNumber) : base(orderId, orderDate)
//        {
//            TrackingNumber = trackingNumber;
//        }

//        public override string GetOrderStatus()
//        {
//            return base.GetOrderStatus() + $", Shipped with tracking number: {TrackingNumber}";
//        }
//    }

//    class DeliveredOrder : ShippedOrder
//    {
//        private string DeliveryDate;

//        public DeliveredOrder(string orderId, string orderDate, string trackingNumber, string deliveryDate) : base(orderId, orderDate, trackingNumber)
//        {
//            DeliveryDate = deliveryDate;
//        }

//        public override string GetOrderStatus()
//        {
//            return base.GetOrderStatus() + $", Delivered on {DeliveryDate}";
//        }
//    }
//}
