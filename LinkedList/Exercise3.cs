using CustomLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CustomLinkedList.Exercise2;
namespace LinkedList
{
    public static class Exercise3
    {
        // Solution 1
        public static MyLinkedList SortMultipleListsVer1(List<MyLinkedList> lists)
        {
            if (lists.Count == 1) return lists[0];
            if (lists.Count == 2) return SortTwoList(lists[0], lists[1]);
            else return SortTwoList(lists[0], SortMultipleListsVer1(lists.GetRange(1, lists.Count - 1)));
        }

        //Solution 2
        public static MyLinkedList SortMultipleListsVer2(List<MyLinkedList> lists)
        {
            if (lists.Count == 2) return SortTwoList(lists[0], lists[1]);
            if (lists.Count == 1) return lists[0];
            else
            {
                int middle = lists.Count / 2;
                return SortTwoList(SortMultipleListsVer2(lists.GetRange(0, middle)), SortMultipleListsVer2(lists.GetRange(middle, lists.Count - middle)));
            }
        }
    }
}
