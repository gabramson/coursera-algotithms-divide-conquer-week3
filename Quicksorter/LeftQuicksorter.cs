using System;
using System.Collections.Generic;
using System.Text;

namespace QuicksorterLib
{
    public class LeftQuicksorter<T> : Quicksorter<T> where T: IComparable
    {
        protected override void SetPivot(int left, int right)
        {
        }
    }
}
