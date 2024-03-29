﻿using System;

namespace SortAlgorithms
{

    public class SortedItem:IComparable
    {
        public int Value { get; set; }
        public SortedItem(int value)
        {
            Value = value;
        }     

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            { return Value.CompareTo(item.Value); }
            else { throw new ArgumentException($"obj is not{nameof(SortedItem)}",nameof(obj)); }
        }
        public override string ToString()
        {
            return Value.ToString();
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
}
