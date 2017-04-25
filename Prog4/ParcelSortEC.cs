// Program 4
// CIS 200-01/76
// Fall 2016
// Due: 11/29/2016
// By: Hermilo Acuna

// File: ParcelSortEC.cs
// This class allows the parcel list to be sorted by type following calculated cost
// right after within each type parcel.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog4
{
    // Precondition:  none
    // Postcondition: p1 < p2, method returns negative number
    // p1 = p2, method returns 0
    // p1 > p2, method returns positive number
    class ParcelSortEC : IComparer<Parcel>
    {
        public int Compare(Parcel p1, Parcel p2)
        {
            // declare type string setting it equal to parcel get type tostring
            string t1 = p1.GetType().ToString();
            string t2 = p2.GetType().ToString();

            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            if (t1 == t2)
                return (-1) *t1.CompareTo(t2);

            return (-1) * (p1.CalcCost()).CompareTo(p2.CalcCost());
        }
    }
}
