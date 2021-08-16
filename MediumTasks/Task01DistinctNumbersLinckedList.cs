using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MediumTasks
{
    public class Task01DistinctNumbersLinckedList
    {
        public LinkedList<int> RemoveDuplicationLinckedList(LinkedList<int> list)
        {
            Dictionary<int, int> dictNums = new Dictionary<int, int>();

            if (list == null || list.Count == 0)
            {
                throw new Exception();
            }

            foreach (var item in list)
            {
                if (dictNums.ContainsKey(item))
                {
                    dictNums[item]++;
                }
                else
                {
                    dictNums[item] = 1;
                }
            }

            var uniqueNums = dictNums.Keys.Where(item => dictNums[item] == 1).OrderBy(item=>item).ToList();

            list.Clear();

            uniqueNums.ForEach(item => list.AddLast(item));

            return list;
        }
    }
}
