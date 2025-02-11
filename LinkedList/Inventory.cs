//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinkedList
//{


//    class Item
//    {
//        public string Name { get; set; }
//        public int Id { get; set; }
//        public int Quantity { get; set; }
//        public double Price { get; set; }
//        public Item Next { get; set; }

//        public Item(string name, int id, int quantity, double price)
//        {
//            Name = name;
//            Id = id;
//            Quantity = quantity;
//            Price = price;
//            Next = null;
//        }
//    }

//    class Inventory
//    {
//        private Item head;

//        public void AddAtBeginning(string name, int id, int quantity, double price)
//        {
//            Item newItem = new Item(name, id, quantity, price);
//            newItem.Next = head;
//            head = newItem;
//        }

//        public void AddAtEnd(string name, int id, int quantity, double price)
//        {
//            Item newItem = new Item(name, id, quantity, price);
//            if (head == null)
//            {
//                head = newItem;
//                return;
//            }
//            Item temp = head;
//            while (temp.Next != null)
//            {
//                temp = temp.Next;
//            }
//            temp.Next = newItem;
//        }

//        public void AddAtPosition(string name, int id, int quantity, double price, int position)
//        {
//            Item newItem = new Item(name, id, quantity, price);
//            if (position == 1)
//            {
//                AddAtBeginning(name, id, quantity, price);
//                return;
//            }
//            Item temp = head;
//            for (int i = 1; i < position - 1 && temp.Next != null; i++)
//            {
//                temp = temp.Next;
//            }
//            newItem.Next = temp.Next;
//            temp.Next = newItem;
//        }

//        public void RemoveById(int id)
//        {
//            if (head == null) return;
//            if (head.Id == id)
//            {
//                head = head.Next;
//                return;
//            }
//            Item temp = head;
//            while (temp.Next != null && temp.Next.Id != id)
//            {
//                temp = temp.Next;
//            }
//            if (temp.Next != null)
//            {
//                temp.Next = temp.Next.Next;
//            }
//        }

//        public void UpdateQuantity(int id, int newQuantity)
//        {
//            Item temp = head;
//            while (temp != null)
//            {
//                if (temp.Id == id)
//                {
//                    temp.Quantity = newQuantity;
//                    return;
//                }
//                temp = temp.Next;
//            }
//        }

//        public Item SearchById(int id)
//        {
//            Item temp = head;
//            while (temp != null)
//            {
//                if (temp.Id == id) return temp;
//                temp = temp.Next;
//            }
//            return null;
//        }

//        public double CalculateTotalValue()
//        {
//            double total = 0;
//            Item temp = head;
//            while (temp != null)
//            {
//                total += temp.Quantity * temp.Price;
//                temp = temp.Next;
//            }
//            return total;
//        }

//        public void SortByPrice()
//        {
//            head = MergeSort(head);
//        }

//        private Item MergeSort(Item head)
//        {
//            if (head == null || head.Next == null) return head;
//            Item middle = GetMiddle(head);
//            Item nextOfMiddle = middle.Next;
//            middle.Next = null;
//            Item left = MergeSort(head);
//            Item right = MergeSort(nextOfMiddle);
//            return Merge(left, right);
//        }

//        private Item Merge(Item left, Item right)
//        {
//            if (left == null) return right;
//            if (right == null) return left;
//            Item result;
//            if (left.Price <= right.Price)
//            {
//                result = left;
//                result.Next = Merge(left.Next, right);
//            }
//            else
//            {
//                result = right;
//                result.Next = Merge(left, right.Next);
//            }
//            return result;
//        }

//        private Item GetMiddle(Item head)
//        {
//            if (head == null) return head;
//            Item slow = head, fast = head;
//            while (fast.Next != null && fast.Next.Next != null)
//            {
//                slow = slow.Next;
//                fast = fast.Next.Next;
//            }
//            return slow;
//        }

//        public void DisplayInventory()
//        {
//            Item temp = head;
//            while (temp != null)
//            {
//                Console.WriteLine($"Item: {temp.Name}, ID: {temp.Id}, Quantity: {temp.Quantity}, Price: {temp.Price}");
//                temp = temp.Next;
//            }
//        }
//    }

//    class InventoryManagement
//    {
//        static void Main()
//        {
//            Inventory inventory = new Inventory();
//            inventory.AddAtEnd("Laptop", 101, 10, 50000);
//            inventory.AddAtEnd("Mouse", 102, 50, 500);
//            inventory.AddAtBeginning("Keyboard", 103, 30, 1000);
//            inventory.AddAtPosition("Monitor", 104, 20, 15000, 2);
//            Console.WriteLine("Inventory List:");
//            inventory.DisplayInventory();
//            inventory.UpdateQuantity(102, 60);
//            Console.WriteLine("Updated Inventory:");
//            inventory.DisplayInventory();
//            Console.WriteLine("Total Inventory Value: " + inventory.CalculateTotalValue());
//            inventory.SortByPrice();
//            Console.WriteLine("Sorted by Price:");
//            inventory.DisplayInventory();
//        }
//    }
//}
