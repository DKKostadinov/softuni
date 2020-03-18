using System.Collections.Generic;

namespace GenericSwapMethodStringsOrInts
{
    public class BoxList<T>
    {
        private List<T> boxList;

        public BoxList()
        {
            boxList = new List<T>();
        }

        public void Add(T element)
        {
            boxList.Add(element);
        }

        public void Swap(int first, int second)
        {
            T temp = boxList[first];
            boxList[first] = boxList[second];
            boxList[second] = temp;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var element in boxList)
            {
                result += $"{element.GetType()}: {element}\n";
            }

            return result;
        }

        public int Compare(T comparator)
        {
            int counter = 0;
            foreach (var box in boxList)
            {
                if ()
                {
                    
                }
            }
        }
    }
}
