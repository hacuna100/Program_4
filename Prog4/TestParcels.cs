// Program 4
// CIS 200-01/76
// Fall 2016
// Due: 11/29/2016
// By: Hermilo Acuna

// File: TestParcels.cs
// This console is used to create parcel lists and sort them based on its defined class.
// It creates several different Parcels and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog4
{
    class TestParcels
    {
        // Precondition:  None
        // Postcondition: Parcels have been created and displayed
        static void Main(string[] args)
        {
            // Test Data - Magic Numbers OK
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter letter1 = new Letter(a1, a2, 3.95M);                            // Letter test object
            GroundPackage gp1 = new GroundPackage(a3, a4, 14, 10, 5, 12.5);        // Ground test object
            NextDayAirPackage ndap1 = new NextDayAirPackage(a1, a3, 25, 15, 15,    // Next Day test object
                85, 7.50M);
            TwoDayAirPackage tdap1 = new TwoDayAirPackage(a4, a1, 46.5, 39.5, 28.0, // Two Day test object
                80.5, TwoDayAirPackage.Delivery.Saver);
            Letter letter2 = new Letter(a4, a2, 5.5M);
            Letter letter3 = new Letter(a3, a2, 2M);
            GroundPackage gp2 = new GroundPackage(a4, a2, 16, 15, 15, 36);
            GroundPackage gp3 = new GroundPackage(a3, a1, 5, 5, 5, 15);
            TwoDayAirPackage tdap2 = new TwoDayAirPackage(a1, a4, 13, 16, 14, 32, TwoDayAirPackage.Delivery.Early);
            NextDayAirPackage ndap2 = new NextDayAirPackage(a3, a2, 17, 10, 10, 27, 13M);

            List<Parcel> parcels;      // List of test parcels

            parcels = new List<Parcel>();

            parcels.Add(letter1); // Populate list
            parcels.Add(gp1);
            parcels.Add(ndap1);
            parcels.Add(tdap1);
            parcels.Add(letter2);
            parcels.Add(letter3);
            parcels.Add(gp2);
            parcels.Add(gp3);
            parcels.Add(tdap2);
            parcels.Add(ndap2);

            // Displays the parcels list as is
            Console.WriteLine("Original List:");
            Console.WriteLine("====================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();
            
            // Displays the parcel list in ascending order by cost
            parcels.Sort();
            Console.WriteLine();
            Console.WriteLine("List Parcels by Cost in Ascending Order");
            Console.WriteLine("=======================================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            // Displays the parcel list by zip code using the ParcelSort class
            parcels.Sort(new ParcelSort());
            Console.WriteLine();
            Console.WriteLine("List Parcels by Zip Code in descending Order");
            Console.WriteLine("=========================================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

            // Displays the parcel list by typ then cost in descending order using the ParcelSortEC Class (or at least it should, couldn't get it to work)
            parcels.Sort(new ParcelSortEC());
            Console.WriteLine();
            Console.WriteLine("List Parcels by type in ascending order and then cost by descending order");
            Console.WriteLine("=====================================================================");
            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("====================");
            }
            Pause();

       }

        // Precondition:  None
        // Postcondition: Pauses program execution until user presses Enter and
        //                then clears the screen
        public static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

            Console.Clear(); // Clear screen
        }
    }
}
