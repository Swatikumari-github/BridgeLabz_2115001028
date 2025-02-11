//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinkedList
//{
    

//    class Ticket
//    {
//        public int TicketID { get; set; }
//        public string CustomerName { get; set; }
//        public string MovieName { get; set; }
//        public string SeatNumber { get; set; }
//        public DateTime BookingTime { get; set; }
//        public Ticket Next { get; set; }

//        public Ticket(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
//        {
//            TicketID = ticketID;
//            CustomerName = customerName;
//            MovieName = movieName;
//            SeatNumber = seatNumber;
//            BookingTime = bookingTime;
//            Next = null;
//        }
//    }

//    class TicketReservationSystem
//    {
//        private Ticket head;
//        private int count;

//        public TicketReservationSystem()
//        {
//            head = null;
//            count = 0;
//        }

//        public void AddTicket(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
//        {
//            Ticket newTicket = new Ticket(ticketID, customerName, movieName, seatNumber, bookingTime);
//            if (head == null)
//            {
//                head = newTicket;
//                head.Next = head;
//            }
//            else
//            {
//                Ticket temp = head;
//                while (temp.Next != head)
//                {
//                    temp = temp.Next;
//                }
//                temp.Next = newTicket;
//                newTicket.Next = head;
//            }
//            count++;
//        }

//        public void RemoveTicket(int ticketID)
//        {
//            if (head == null) return;
//            Ticket temp = head, prev = null;
//            do
//            {
//                if (temp.TicketID == ticketID)
//                {
//                    if (prev != null)
//                    {
//                        prev.Next = temp.Next;
//                    }
//                    else
//                    {
//                        Ticket last = head;
//                        while (last.Next != head)
//                        {
//                            last = last.Next;
//                        }
//                        head = head.Next;
//                        last.Next = head;
//                    }
//                    count--;
//                    return;
//                }
//                prev = temp;
//                temp = temp.Next;
//            } while (temp != head);
//        }

//        public void DisplayTickets()
//        {
//            if (head == null)
//            {
//                Console.WriteLine("No tickets booked.");
//                return;
//            }
//            Ticket temp = head;
//            do
//            {
//                Console.WriteLine($"Ticket ID: {temp.TicketID}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Time: {temp.BookingTime}");
//                temp = temp.Next;
//            } while (temp != head);
//        }

//        public Ticket SearchTicket(string query)
//        {
//            if (head == null) return null;
//            Ticket temp = head;
//            do
//            {
//                if (temp.CustomerName.Equals(query, StringComparison.OrdinalIgnoreCase) || temp.MovieName.Equals(query, StringComparison.OrdinalIgnoreCase))
//                    return temp;
//                temp = temp.Next;
//            } while (temp != head);
//            return null;
//        }

//        public int GetTotalTickets()
//        {
//            return count;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            TicketReservationSystem system = new TicketReservationSystem();
//            system.AddTicket(101, "Alice", "Inception", "A12", DateTime.Now);
//            system.AddTicket(102, "Bob", "Interstellar", "B5", DateTime.Now);
//            system.DisplayTickets();
//            Console.WriteLine("Total Tickets: " + system.GetTotalTickets());
//            system.RemoveTicket(101);
//            system.DisplayTickets();
//        }
//    }

//}
