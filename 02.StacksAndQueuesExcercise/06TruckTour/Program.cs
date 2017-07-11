using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        var petrolStations = new Queue<int[]>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            petrolStations.Enqueue(input);
        }

        var reachFinal = false;
        var startingIndex = 0;
        while (!reachFinal)
        {
            var totalPetrol = 0;
            for (int i = 0; i <= n; i++)
            {
                if(i == n)
                {
                    reachFinal = true;
                    break;
                }
                var petrolStation = petrolStations.Dequeue();
                petrolStations.Enqueue(petrolStation);

                var liters = petrolStation[0];
                var distanceToNext = petrolStation[1];
                totalPetrol += liters - distanceToNext;

                if(totalPetrol < 0)
                {
                    startingIndex += i + 1;
                    break;
                }
            }
        }

        Console.WriteLine(startingIndex);
    }
}