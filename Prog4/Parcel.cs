// Program 4
// CIS 200-01/76
// Fall 2016
// Due: 11/29/2016
// By: Hermilo Acuna

// File: Parcel.cs
// Parcel serves as the abstract base class of the Parcel hierachy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Parcel : IComparable<Parcel>
{
    // Precondition:  None
    // Postcondition: The parcel is created with the specified values for
    //                origin address and destination address
    public Parcel(Address originAddress, Address destAddress)
    {
        OriginAddress = originAddress;
        DestinationAddress = destAddress;

    }

    //public Parcel(Parcel compareTo)
    //   : this(compareTo.DestinationAddress, compareTo.OriginAddress) { }


    public Address OriginAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's origin address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's origin address has been set to the
        //                specified value
        set;
    }

    public Address DestinationAddress
    {
        // Precondition:  None
        // Postcondition: The parcel's destination address has been returned
        get;

        // Precondition:  None
        // Postcondition: The parcel's destination address has been set to the
        //                specified value
        set;
    }

    // Precondition:  none
    // Postcondition: p1 < p2, method returns negative number
    // p1 = p2, method returns 0
    // p1 > p2, method returns positive number
    public virtual int CompareTo(Parcel p2)
    {
        if (this == null && p2 == null)
            return 0;

        if (this == null)
            return -1;

        if (p2 == null)
            return 1;

        if (this.CalcCost().CompareTo(p2.CalcCost()) != 0)
            return this.CalcCost().CompareTo(p2.CalcCost());
        else
            return string.Compare(this.CalcCost().ToString(), p2.CalcCost().ToString());
    }

    // Precondition:  None
    // Postcondition: The parcel's cost has been returned
    public abstract decimal CalcCost();

    // Precondition:  None
    // Postcondition: A String with the parcel's data has been returned
    public override String ToString()
    {
        return String.Format("Origin Address:{3}{0}{3}{3}Destination Address:{3}{1}{3}Cost: {2:C}",
            OriginAddress, DestinationAddress, CalcCost(), Environment.NewLine);
    }
}
