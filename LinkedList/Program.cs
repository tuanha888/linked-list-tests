using CustomLinkedList;
using LinkedList;


//Chạy test bài 1
var list = new MyLinkedList();
list.AddMultipleValues(2, 3, 1, 3, 4, 5, 6, 7, 3, 2, 4, 3, 4, 3, 4, 3, 3, 6, 7, 8, 9, 12, 13, 3, 1, 4, 2, 3, 5);
Console.WriteLine("List before deleted");
list.Print();
list.DeleteValues(3);
Console.WriteLine("List after deleted");
list.Print();


//Chạy test bài 2
var list1 = new MyLinkedList();
list1.AddMultipleValues(2, 3, 4, 7, 8, 13, 24, 25, 32, 35, 46);
var list2 = new MyLinkedList();
list2.AddMultipleValues(2, 3, 3, 3, 4, 5, 6, 8, 9, 43, 45, 46, 49, 50, 54);
Console.WriteLine("2 lists before merged");
var mergedList = Exercise2.SortTwoList(list1, list2);
Console.WriteLine("after merged");
mergedList.Print();

//Chạy test bài 3
var lists = new List<MyLinkedList>();
var list3 = new MyLinkedList();
list3.AddMultipleValues(2, 3, 4, 5, 6, 7, 8);
var list4 = new MyLinkedList();
list4.AddMultipleValues(2, 3, 4, 5, 6, 7, 8, 9, 10);

lists.Add(list1);
lists.Add(list2);
lists.Add(list3);
lists.Add(list4);

var sortedList = Exercise3.SortMultipleListsVer1(lists);
var sortListVer2 = Exercise3.SortMultipleListsVer2(lists);
sortedList.Print();
sortListVer2.Print();


