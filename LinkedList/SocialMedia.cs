//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinkedList
//{
  

//    class User
//    {
//        public int UserID { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public List<int> FriendIDs { get; set; }
//        public User Next { get; set; }

//        public User(int userID, string name, int age)
//        {
//            UserID = userID;
//            Name = name;
//            Age = age;
//            FriendIDs = new List<int>();
//            Next = null;
//        }
//    }

//    class SocialMediaNetwork
//    {
//        private User head;

//        public void AddUser(int userID, string name, int age)
//        {
//            User newUser = new User(userID, name, age);
//            if (head == null)
//            {
//                head = newUser;
//            }
//            else
//            {
//                User temp = head;
//                while (temp.Next != null)
//                    temp = temp.Next;
//                temp.Next = newUser;
//            }
//        }

//        public void AddFriendConnection(int userID1, int userID2)
//        {
//            User user1 = SearchByID(userID1);
//            User user2 = SearchByID(userID2);
//            if (user1 != null && user2 != null)
//            {
//                if (!user1.FriendIDs.Contains(userID2))
//                    user1.FriendIDs.Add(userID2);
//                if (!user2.FriendIDs.Contains(userID1))
//                    user2.FriendIDs.Add(userID1);
//            }
//        }

//        public void RemoveFriendConnection(int userID1, int userID2)
//        {
//            User user1 = SearchByID(userID1);
//            User user2 = SearchByID(userID2);
//            if (user1 != null && user2 != null)
//            {
//                user1.FriendIDs.Remove(userID2);
//                user2.FriendIDs.Remove(userID1);
//            }
//        }

//        public void DisplayFriends(int userID)
//        {
//            User user = SearchByID(userID);
//            if (user != null)
//            {
//                Console.WriteLine($"Friends of {user.Name}:");
//                foreach (int friendID in user.FriendIDs)
//                {
//                    User friend = SearchByID(friendID);
//                    if (friend != null)
//                        Console.WriteLine($"UserID: {friend.UserID}, Name: {friend.Name}");
//                }
//            }
//        }

//        public void FindMutualFriends(int userID1, int userID2)
//        {
//            User user1 = SearchByID(userID1);
//            User user2 = SearchByID(userID2);
//            if (user1 != null && user2 != null)
//            {
//                HashSet<int> mutualFriends = new HashSet<int>(user1.FriendIDs);
//                mutualFriends.IntersectWith(user2.FriendIDs);
//                Console.WriteLine("Mutual Friends:");
//                foreach (int friendID in mutualFriends)
//                {
//                    User friend = SearchByID(friendID);
//                    if (friend != null)
//                        Console.WriteLine($"UserID: {friend.UserID}, Name: {friend.Name}");
//                }
//            }
//        }

//        public User SearchByID(int userID)
//        {
//            User temp = head;
//            while (temp != null)
//            {
//                if (temp.UserID == userID)
//                    return temp;
//                temp = temp.Next;
//            }
//            return null;
//        }

//        public User SearchByName(string name)
//        {
//            User temp = head;
//            while (temp != null)
//            {
//                if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
//                    return temp;
//                temp = temp.Next;
//            }
//            return null;
//        }

//        public void CountFriends()
//        {
//            User temp = head;
//            while (temp != null)
//            {
//                Console.WriteLine($"{temp.Name} has {temp.FriendIDs.Count} friends.");
//                temp = temp.Next;
//            }
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            SocialMediaNetwork network = new SocialMediaNetwork();
//            network.AddUser(1, "Alice", 25);
//            network.AddUser(2, "Bob", 30);
//            network.AddUser(3, "Charlie", 28);

//            network.AddFriendConnection(1, 2);
//            network.AddFriendConnection(1, 3);

//            network.DisplayFriends(1);
//            network.FindMutualFriends(2, 3);
//            network.CountFriends();
//        }
//    }
//}
