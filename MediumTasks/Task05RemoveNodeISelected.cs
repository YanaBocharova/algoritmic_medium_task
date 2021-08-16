using System;
using System.Collections.Generic;
using System.Text;

namespace MediumTasks
{
    public class Task05RemoveNodeISelected
    {
		public LinkedList<int> RemoveElementAtTail(LinkedList<int> list, int index)
        {
			if (list == null || list.Count == 0)
			{
				throw new Exception();
			}

			int counter = 0;

            if (list.Count >= index)
            {
				var nodePtr = list.Last;

				while (nodePtr.Previous != null)
				{
					nodePtr = nodePtr.Previous;
					counter++;

					if (counter == index - 1)
					{
						list.Remove(nodePtr);
						return list;
					}
				}
			}

			return list;
		}
	}
}
