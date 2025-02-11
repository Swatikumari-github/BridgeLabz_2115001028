//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinkedList
//{
   

//    class TaskNode
//    {
//        public int TaskID;
//        public string TaskName;
//        public int Priority;
//        public DateTime DueDate;
//        public TaskNode Next;

//        public TaskNode(int taskId, string taskName, int priority, DateTime dueDate)
//        {
//            TaskID = taskId;
//            TaskName = taskName;
//            Priority = priority;
//            DueDate = dueDate;
//            Next = this; // Circular reference
//        }
//    }

//    class TaskScheduler
//    {
//        private TaskNode head;
//        private TaskNode current;

//        public void AddTaskAtBeginning(int taskId, string taskName, int priority, DateTime dueDate)
//        {
//            TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
//            if (head == null)
//            {
//                head = newTask;
//                head.Next = head;
//            }
//            else
//            {
//                TaskNode temp = head;
//                while (temp.Next != head)
//                {
//                    temp = temp.Next;
//                }
//                newTask.Next = head;
//                temp.Next = newTask;
//                head = newTask;
//            }
//        }

//        public void AddTaskAtEnd(int taskId, string taskName, int priority, DateTime dueDate)
//        {
//            TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
//            if (head == null)
//            {
//                head = newTask;
//            }
//            else
//            {
//                TaskNode temp = head;
//                while (temp.Next != head)
//                {
//                    temp = temp.Next;
//                }
//                temp.Next = newTask;
//                newTask.Next = head;
//            }
//        }

//        public void AddTaskAtPosition(int taskId, string taskName, int priority, DateTime dueDate, int position)
//        {
//            if (position < 1)
//            {
//                Console.WriteLine("Invalid position!");
//                return;
//            }
//            TaskNode newTask = new TaskNode(taskId, taskName, priority, dueDate);
//            if (position == 1)
//            {
//                AddTaskAtBeginning(taskId, taskName, priority, dueDate);
//                return;
//            }
//            TaskNode temp = head;
//            for (int i = 1; temp.Next != head && i < position - 1; i++)
//            {
//                temp = temp.Next;
//            }
//            newTask.Next = temp.Next;
//            temp.Next = newTask;
//        }

//        public void RemoveTaskById(int taskId)
//        {
//            if (head == null)
//            {
//                Console.WriteLine("No tasks to remove.");
//                return;
//            }
//            TaskNode temp = head, prev = null;
//            do
//            {
//                if (temp.TaskID == taskId)
//                {
//                    if (temp == head)
//                    {
//                        TaskNode last = head;
//                        while (last.Next != head)
//                        {
//                            last = last.Next;
//                        }
//                        head = head.Next;
//                        last.Next = head;
//                    }
//                    else
//                    {
//                        prev.Next = temp.Next;
//                    }
//                    Console.WriteLine("Task removed successfully.");
//                    return;
//                }
//                prev = temp;
//                temp = temp.Next;
//            } while (temp != head);
//            Console.WriteLine("Task not found.");
//        }

//        public void ViewCurrentTask()
//        {
//            if (current == null)
//            {
//                current = head;
//            }
//            if (current != null)
//            {
//                Console.WriteLine($"Current Task -> ID: {current.TaskID}, Name: {current.TaskName}, Priority: {current.Priority}, Due Date: {current.DueDate}");
//                current = current.Next;
//            }
//            else
//            {
//                Console.WriteLine("No tasks available.");
//            }
//        }

//        public void DisplayTasks()
//        {
//            if (head == null)
//            {
//                Console.WriteLine("No tasks to display.");
//                return;
//            }
//            TaskNode temp = head;
//            do
//            {
//                Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate}");
//                temp = temp.Next;
//            } while (temp != head);
//        }

//        public TaskNode SearchTaskByPriority(int priority)
//        {
//            TaskNode temp = head;
//            if (temp == null)
//            {
//                return null;
//            }
//            do
//            {
//                if (temp.Priority == priority)
//                    return temp;
//                temp = temp.Next;
//            } while (temp != head);
//            return null;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            TaskScheduler scheduler = new TaskScheduler();

//            scheduler.AddTaskAtEnd(1, "Complete Report", 2, DateTime.Now.AddDays(2));
//            scheduler.AddTaskAtEnd(2, "Team Meeting", 1, DateTime.Now.AddDays(1));
//            scheduler.AddTaskAtBeginning(3, "Code Review", 3, DateTime.Now.AddDays(3));

//            Console.WriteLine("All Tasks:");
//            scheduler.DisplayTasks();

//            Console.WriteLine("\nViewing Current Task:");
//            scheduler.ViewCurrentTask();

//            Console.WriteLine("\nRemoving Task with ID 2:");
//            scheduler.RemoveTaskById(2);
//            scheduler.DisplayTasks();

//            Console.WriteLine("\nSearching Task by Priority 3:");
//            TaskNode foundTask = scheduler.SearchTaskByPriority(3);
//            if (foundTask != null)
//                Console.WriteLine($"Found Task -> ID: {foundTask.TaskID}, Name: {foundTask.TaskName}, Priority: {foundTask.Priority}, Due Date: {foundTask.DueDate}");
//            else
//                Console.WriteLine("No task found with the given priority.");
//        }
//    }

//}
