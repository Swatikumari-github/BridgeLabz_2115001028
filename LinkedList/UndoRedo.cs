//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinkedList
//{
    

//    class TextState
//    {
//        public string Content { get; set; }
//        public TextState Prev { get; set; }
//        public TextState Next { get; set; }

//        public TextState(string content)
//        {
//            Content = content;
//            Prev = null;
//            Next = null;
//        }
//    }

//    class TextEditor
//    {
//        private TextState current;
//        private int historyLimit;
//        private int historyCount;

//        public TextEditor(int limit = 10)
//        {
//            current = null;
//            historyLimit = limit;
//            historyCount = 0;
//        }

//        public void AddState(string content)
//        {
//            TextState newState = new TextState(content);
//            if (current != null)
//            {
//                newState.Prev = current;
//                current.Next = newState;
//            }
//            current = newState;
//            historyCount++;

//            if (historyCount > historyLimit)
//            {
//                RemoveOldestState();
//            }
//        }

//        private void RemoveOldestState()
//        {
//            TextState temp = current;
//            while (temp.Prev != null)
//            {
//                temp = temp.Prev;
//            }
//            if (temp.Next != null)
//            {
//                temp.Next.Prev = null;
//            }
//            historyCount--;
//        }

//        public void Undo()
//        {
//            if (current != null && current.Prev != null)
//            {
//                current = current.Prev;
//            }
//        }

//        public void Redo()
//        {
//            if (current != null && current.Next != null)
//            {
//                current = current.Next;
//            }
//        }

//        public void DisplayCurrentState()
//        {
//            if (current != null)
//            {
//                Console.WriteLine("Current Text State: " + current.Content);
//            }
//            else
//            {
//                Console.WriteLine("No text available.");
//            }
//        }
//    }

//    class UndoRedo
//    {
//        static void Main()
//        {
//            TextEditor editor = new TextEditor();
//            editor.AddState("Hello");
//            editor.AddState("Hello, World!");
//            editor.DisplayCurrentState();

//            editor.Undo();
//            editor.DisplayCurrentState();

//            editor.Redo();
//            editor.DisplayCurrentState();
//        }
//    }

//}
