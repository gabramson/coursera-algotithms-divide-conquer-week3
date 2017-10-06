using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuicksorterLib
{
    public class Quicksorter<T> where T : IComparable
    {
        private List<T> elements = new List<T>();

        public void Add(T value)
        {
            elements.Add(value);
        }

        public int Comparisons { private set; get; } = 0;
        public List<T> SortedCopy{ get { return elements.AsReadOnly(); }  }
//        public List<T> SortedCopy { get {return elements.AsReadOnly();} }

        public void Sort()
        {
            Partition(0, elements.Count-1);
            Comparisons = 1;
        }

        private void Partition(int start, int end)
        {
            T pivotValue;

            if (start != end)
            {
                int pivotIndex = start;
                pivotValue = elements[start];
                int i = start + 1;
                for (int j=i; j<=end; j+= 1)
                {
                    if (IsIncreasing(elements[j], pivotValue))
                    {
                        Swap(i, j);
                        i += 1;
                    }
                }
                Swap(pivotIndex, i - 1);
            }
        }

        private bool IsIncreasing(T first, T second)
        {
            Comparisons += 1;
            return first.CompareTo(second) < 0;
        }

        private void Swap(int i, int j)
        {
            T temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }
    }
}
