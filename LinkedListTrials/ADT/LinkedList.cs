using System.Text;

namespace ADT
{
    public class LinkedList
    {
        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }

            public Node(object data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;

        public Node Head
        {
            get { return head; }
            set { head = value; }
        }

        private int count;

        public int Count => count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void InsertAt(int index, object o)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }

            Node newNode = new Node(o);
            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            count++;
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }

            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
            count--;
        }

        public object ItemAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range.");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            Node current = head;
            while (current != null)
            {
                sb.Append(current.Data + "\n");
                current = current.Next;
            }
            return sb.ToString().TrimEnd('\n');
        }
    }
}
