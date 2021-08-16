using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediumTasks
{
    public class Task04SumNumbersLinkedList
    {
        public LinkedList<int> SumNumbersLinkedList(LinkedList<int> listX, LinkedList<int> listY)
        {
            if ((listX == null || listX.Count == 0) || (listY == null || listY.Count == 0))
            {
                throw new Exception();
            }

            StringBuilder builderX = new StringBuilder(listX.Count);
            StringBuilder builderY = new StringBuilder();

            int countX = listX.Count;
            int countY = listY.Count;

            for (int i = 0; i < countX; i++)
            {
                builderX.Append(listX.Last.Value.ToString());
                listX.RemoveLast();
            }

            for (int i = 0; i < countY; i++)
            {
                builderY.Append(listY.Last.Value.ToString());
                listY.RemoveLast();
            }

            int num1;
            int.TryParse(builderX.ToString(), out num1);

            int num2;
            int.TryParse(builderY.ToString(), out num2);

            int sumNumber = num1 + num2;

            var listSum = sumNumber.ToString().ToCharArray().ToList();

            var listOutPut = new LinkedList<int>();

            listSum.ForEach(item => listOutPut.AddFirst(int.Parse(item.ToString())));

            return listOutPut;
        }
    }
}
