using System;
using System.Collections.Generic;
using System.Text;

namespace QuicksorterLib
{
    public class RightQuicksorter<T> : Quicksorter<T> where T : IComparable
    {
        protected override void  SetPivot(int left, int right)
        {
            Swap(left, right);
        }
    }
}
