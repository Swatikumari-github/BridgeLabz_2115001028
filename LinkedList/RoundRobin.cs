//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinkedList
//{
   

//    class Process
//    {
//        public int ProcessID { get; set; }
//        public int BurstTime { get; set; }
//        public int Priority { get; set; }
//        public Process Next { get; set; }

//        public Process(int processID, int burstTime, int priority)
//        {
//            ProcessID = processID;
//            BurstTime = burstTime;
//            Priority = priority;
//            Next = null;
//        }
//    }

//    class RoundRobinScheduler
//    {
//        private Process head = null, tail = null;
//        private int timeQuantum;

//        public RoundRobinScheduler(int quantum)
//        {
//            timeQuantum = quantum;
//        }

//        public void AddProcess(int processID, int burstTime, int priority)
//        {
//            Process newProcess = new Process(processID, burstTime, priority);
//            if (head == null)
//            {
//                head = newProcess;
//                tail = newProcess;
//                tail.Next = head;
//            }
//            else
//            {
//                tail.Next = newProcess;
//                tail = newProcess;
//                tail.Next = head;
//            }
//        }

//        public void RemoveProcess(int processID)
//        {
//            if (head == null) return;
//            Process temp = head, prev = null;

//            do
//            {
//                if (temp.ProcessID == processID)
//                {
//                    if (temp == head)
//                    {
//                        tail.Next = head.Next;
//                        head = head.Next;
//                    }
//                    else if (temp == tail)
//                    {
//                        prev.Next = head;
//                        tail = prev;
//                    }
//                    else
//                    {
//                        prev.Next = temp.Next;
//                    }
//                    return;
//                }
//                prev = temp;
//                temp = temp.Next;
//            } while (temp != head);
//        }

//        public void SimulateScheduling()
//        {
//            int time = 0, waitingTime = 0, turnAroundTime = 0, processCount = 0;
//            Process temp = head;

//            while (temp != null)
//            {
//                processCount++;
//                temp = temp.Next;
//                if (temp == head) break;
//            }

//            while (head != null)
//            {
//                Console.WriteLine("Current Process Queue:");
//                DisplayProcesses();
//                Process current = head;

//                do
//                {
//                    if (current.BurstTime > 0)
//                    {
//                        int executeTime = Math.Min(timeQuantum, current.BurstTime);
//                        time += executeTime;
//                        current.BurstTime -= executeTime;

//                        if (current.BurstTime == 0)
//                        {
//                            turnAroundTime += time;
//                            RemoveProcess(current.ProcessID);
//                            processCount--;
//                        }
//                    }
//                    current = current.Next;
//                } while (current != head && processCount > 0);
//            }

//            waitingTime = turnAroundTime - time;
//            Console.WriteLine($"Average Waiting Time: {(double)waitingTime / processCount}");
//            Console.WriteLine($"Average Turn-Around Time: {(double)turnAroundTime / processCount}");
//        }

//        public void DisplayProcesses()
//        {
//            if (head == null)
//            {
//                Console.WriteLine("No processes in the queue.");
//                return;
//            }
//            Process temp = head;
//            do
//            {
//                Console.WriteLine($"Process ID: {temp.ProcessID}, Burst Time: {temp.BurstTime}, Priority: {temp.Priority}");
//                temp = temp.Next;
//            } while (temp != head);
//        }
//    }

//    class RoundRobin
//    {
//        static void Main()
//        {
//            RoundRobinScheduler scheduler = new RoundRobinScheduler(4);
//            scheduler.AddProcess(1, 10, 1);
//            scheduler.AddProcess(2, 5, 2);
//            scheduler.AddProcess(3, 8, 3);

//            scheduler.SimulateScheduling();
//        }
//    }

//}
