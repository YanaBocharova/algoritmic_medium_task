using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MediumTasks
{
    public class Task02LinkedListSorted
    {
        public LinkedList<int> SortLinkedList(LinkedList<int> inputList)
        {
            if (inputList == null || inputList.Count == 0)
            {
                throw new Exception();
            }
            var temporaryList = inputList.ToArray().OrderBy(item => item).ToList();

            inputList.Clear();

            temporaryList.ForEach(item =>
            {
                inputList.AddLast(item);
            });

            return inputList;
        }
    }
}
