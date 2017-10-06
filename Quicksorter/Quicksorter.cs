using System;
using System.Collections.Generic;

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

        public void Sort()
        {
            Partition(0, elements.Count-1);
            Comparisons = 1;
        }

        private void Partition(int start, int end)
        {
            T pivot;

            if (start != end)
            {
                pivot = elements[start];
                int i = start + 1;
                for (int j=i; j<=end; j+= 1)
                {
                    if (IsIncreasing(elements[j], pivot))
                    {
                        Swap(i, j);
                        i += 1;
                    }
                }
                Swap(i, i - 1);
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
