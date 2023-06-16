using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public static class Exercise2
    {
        public static MyLinkedList SortTwoList(MyLinkedList list1, MyLinkedList list2)
        {
            Node headOfList1 = list1.Head;
            Node headOfList2 = list2.Head;
            var newList = new MyLinkedList();
            while (headOfList1 != null || headOfList2 != null)
            {
                if (headOfList1 == null)
                {
                    newList.Add(headOfList2.data);
                    headOfList2 = headOfList2.nextNode;
                    continue;
                }
                if (headOfList2 == null)
                {
                    newList.Add(headOfList1.data);
                    headOfList1 = headOfList1.nextNode;
                    continue;
                }
                if (headOfList1.data < headOfList2.data)
                {
                    newList.Add(headOfList1.data);
                    headOfList1 = headOfList1.nextNode;
                }
                else
                {
                    newList.Add(headOfList2.data);
                    headOfList2 = headOfList2.nextNode;
                }
            }
            return newList;
        }
    }
}
