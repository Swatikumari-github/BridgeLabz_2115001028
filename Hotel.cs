//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Oops_Assignmemt
//{
//    class HotelBooking
//    {
//        private string guestName;
//        private string roomType;
//        private int nights;

//        // Default Constructor
//        public HotelBooking() : this("Unknown", "Standard", 1) { }

//        // Parameterized Constructor
//        public HotelBooking(string guestName, string roomType, int nights)
//        {
//            this.guestName = guestName;
//            this.roomType = roomType;
//            this.nights = nights;
//        }

//        // Copy Constructor
//        public HotelBooking(HotelBooking other)
//        {
//            this.guestName = other.guestName;
//            this.roomType = other.roomType;
//            this.nights = other.nights;
//        }

//        public void Display()
//        {
//            Console.WriteLine($"Guest: {guestName}, Room Type: {roomType}, Nights: {nights}");
//        }
//    }

//    // Example Usage
//    class Program
//    {
//        static void Main()
//        {
//            HotelBooking booking1 = new HotelBooking();  // Using default constructor
//            HotelBooking booking2 = new HotelBooking("Swati", "Single", 1);  // Using parameterized constructor
//            HotelBooking booking3 = new HotelBooking(booking2);  // Using copy constructor

//            booking1.Display();
//            booking2.Display();
//            booking3.Display();
//        }
//    }

//}
