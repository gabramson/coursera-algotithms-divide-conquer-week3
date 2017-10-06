using System;
using System.Collections.Generic;
using System.Text;

namespace QuicksorterLib
{
    public class MidQuicksorter<T> : Quicksorter<T> where T : IComparable
    {
        protected override void SetPivot(int left, int right)
        {
            if (right > left + 1)
            {
                int mid = (left + right + 2) / 2 - 1;
                var indexList = new SortedList<T, int> {
                    { elements[left], left},
                    { elements[mid], mid},
                    { elements[right], right}
                };
                Swap(left, indexList.Values[1]);
            }
        }
    }
}
