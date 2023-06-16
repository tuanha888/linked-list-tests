using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class MyLinkedList
    {
        private int size;
        public Node Head = null;
        public int Length() => size;
        public bool IsEmpty() => size == 0;
        public void Add(int value)
        {
            if (Head == null) Head = new Node(value, null);
            else
            {
                Node tmp = Head;
                while (tmp.nextNode != null)
                {
                    tmp = tmp.nextNode;
                }
                tmp.nextNode = new Node(value, null);
            }
        }
        public void DeleteFirst()
        {
            if (Head == null)
                throw new InvalidOperationException("Linked list is empty now!");
            Head = Head.nextNode;
        }
        public void AddMultipleValues(params int[] arr)
        {
            for (int i=0; i<arr.Length; ++i)
            {
                Add(arr[i]);
            }
        }
        public void DeleteValues(int value)
        {
            Node tmp = Head;
            Node p1 = tmp.nextNode;
            while (p1 != null)
            {
                if (p1.data == value)
                {
                    tmp.nextNode = p1.nextNode;
                    p1 = p1.nextNode;
                    --size;
                }
                else
                {
                    tmp = tmp.nextNode;
                    p1 = p1.nextNode;
                }

            }
            if (Head.data == value) DeleteFirst();
        }
        public void Print()
        {
            Node tmp = Head;
            while (tmp != null)
            {
                Console.Write($"{tmp.data} ");
                tmp = tmp.nextNode;
            }
            Console.WriteLine();
        }
    }
}
