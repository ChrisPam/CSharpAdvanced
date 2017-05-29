using System;
using System.Collections.Generic;
using System.Linq;

public class ParkingLot
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        SortedSet<string> parking = new SortedSet<string>();

        while (input[0] != "END")
        {
            var command = input[0];

            if(command.ToLower() == "in")
            {
                parking.Add(input[1]);
            }
            else if(command.ToLower() == "out")
            {
                parking.Remove(input[1]);
            }


            input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        if (parking.Count != 0)
        {
            foreach (var cars in parking)
            {
                Console.WriteLine(cars);
            }
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}