// Program 4
// CIS 200-01/76
// Fall 2016
// Due: 11/29/2016
// By: Hermilo Acuna

// File: ParcelSort.cs
// This class allows the parcel list to be sorted by destination zip in descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog4
{
    public class ParcelSort : IComparer<Parcel>
    {
        // Precondition:  none
        // Postcondition: p1 < p2, method returns negative number
        // p1 = p2, method returns 0
        // p1 > p2, method returns positive number
        public int Compare(Parcel p1, Parcel p2)
        {
            if (p1 == null && p2 == null)
                return 0;

            if (p1 == null)
                return -1;

            if (p2 == null)
                return 1;

            return p2.DestinationAddress.Zip.CompareTo(p1.DestinationAddress.Zip);
        }
    }
}
