using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuicksorterLib
{
    public abstract class Quicksorter<T> where T : IComparable
    {
        protected List<T> elements = new List<T>();

        public void Add(T value)
        {
            elements.Add(value);
        }

        public int Comparisons { private set; get; } = 0;
        public ReadOnlyCollection<T> SortedCopy { private set; get; }

        public void Sort()
        {
            Comparisons = 0;
            Partition(0, elements.Count-1);
            SortedCopy = elements.AsReadOnly();
        }

        protected abstract void SetPivot(int left, int right);

        protected void Swap(int i, int j)
        {
            T temp = elements[i];
            elements[i] = elements[j];
            elements[j] = temp;
        }

        private void Partition(int left, int right)
        {
            T pivotValue;

            if (left < right)
            {
                SetPivot(left, right);
                int pivotIndex = left;
                pivotValue = elements[pivotIndex];
                int i = left + 1;
                for (int j=i; j<=right; j+= 1)
                {
                    if (IsIncreasing(elements[j], pivotValue))
                    {
                        Swap(i, j);
                        i += 1;
                    }
                }
                Swap(pivotIndex, i - 1);
                pivotIndex = i - 1;
                if (pivotIndex>= left+2)
                {
                    Partition(left, pivotIndex - 1);
                }
                if (pivotIndex<= right - 2){
                    Partition(pivotIndex + 1, right);
                }
            }
        }

        private bool IsIncreasing(T first, T second)
        {
            Comparisons += 1;
            return first.CompareTo(second) < 0;
        }
    }
}
