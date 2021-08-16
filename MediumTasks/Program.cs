using System;
using System.Collections.Generic;
using System.Linq;

namespace MediumTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowOutputLinckedList();

            //ShowLinkedListSorted();

            //ShowMergeSortedLists();

            //ShowSumNumbersLinkedList();

            //ShowRemoveNodeISelected();
        }

        private static void ShowRemoveNodeISelected()
        {
            var removeNodeISelected = new Task05RemoveNodeISelected();

            int index = 2;

            var list = new LinkedList<int>();

            list.AddLast(1);
            list.AddLast(9);
            list.AddLast(2);
            list.AddLast(30);
            list.AddLast(100);
            list.AddLast(1000);

            var listOutput = removeNodeISelected.RemoveElementAtTail(list, index);

            listOutput.ToList().ForEach(item => Console.WriteLine(item.ToString(), 3));
        }

        private static void ShowSumNumbersLinkedList()
        {
            var listX = new LinkedList<int>();
            var listY = new LinkedList<int>();

            listX.AddLast(1);
            listX.AddLast(9);
            listX.AddLast(2);

            listY.AddLast(4);
            listY.AddLast(8);
            listY.AddLast(8); 

            var sumOutput = new Task04SumNumbersLinkedList();

            var listOutput = sumOutput.SumNumbersLinkedList(listX, listY);

            listOutput.ToList().ForEach(item => Console.Write(item.ToString(), 1));
        }

        private static void ShowMergeSortedLists()
        {
            var list1 = new LinkedList<int>();
            var list2 = new LinkedList<int>();
            var list3 = new LinkedList<int>();

            list1.AddLast(1);
            list1.AddLast(10);
            list1.AddLast(100);

            list2.AddLast(4);
            list2.AddLast(2);
            list2.AddLast(1);

            list3.AddLast(80);
            list3.AddLast(55);
            list3.AddLast(11);
 
            var sortedListMerged = new Task03MergeSortedLists();

            LinkedList<int> listOutput = sortedListMerged.MergeSortedLists(list1, list2, list3);

            listOutput.ToList().ForEach(item => Console.WriteLine(item.ToString()));
        }

        private static void ShowLinkedListSorted()
        {
            LinkedList<int> inputList = new LinkedList<int>();

            inputList.AddLast(19);
            inputList.AddLast(1);
            inputList.AddLast(3);
            inputList.AddLast(700); 

            var list = new Task02LinkedListSorted();

            var listOutput = list.SortLinkedList(inputList);

            listOutput.ToList().ForEach(item => Console.WriteLine(item.ToString()));
        }

        private static void ShowOutputLinckedList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(12);
            list.AddLast(12);
            list.AddLast(1);
            list.AddLast(3);
            list.AddLast(3); 

            var distinctNumbersLinckedList = new Task01DistinctNumbersLinckedList();

            var listOutput = distinctNumbersLinckedList.RemoveDuplicationLinckedList(list);

            listOutput.ToList().ForEach(item => Console.WriteLine(item.ToString()));
        }
    }
}
