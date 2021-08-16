using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MediumTasks
{
    public class Task03MergeSortedLists
    {
        public LinkedList<int> MergeSortedLists(LinkedList<int> list1, LinkedList<int> list2, LinkedList<int> list3)
        {
            if (list1 == null || list2 == null || list3 == null)
            {
                throw new Exception();
            }

            var array = new LinkedList<int>[] { list1, list2, list3 };

            for (int i = 1; i < array.Length; i++)
            {
                array[i].ToList().ForEach(item =>
                {
                    array[0].AddLast(item);
                });
            }

            var temporaryList = array[0].ToArray().OrderBy(item => item).ToList();

            array[0].Clear();

            temporaryList.ForEach(item =>
            {
                array[0].AddLast(item);
            });
           
            return array[0];
        }
    }
}
