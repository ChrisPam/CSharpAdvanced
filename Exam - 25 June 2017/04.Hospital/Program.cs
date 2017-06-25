using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var departments = new Dictionary<string, List<string>>();
        var doctors = new Dictionary<string, List<string>>();
        var departmentRooms = new Dictionary<string, Dictionary<int, List<string>>>();


        while (input[0].ToLower() != "output")
        {
            var roomCode = 1;
            var department = input[0];
            var doctorName = input[1] + " " + input[2];
            var patient = input[3];

            if (!departmentRooms.ContainsKey(department))
            {
                departmentRooms[department] = new Dictionary<int, List<string>>();
            }
            if (departmentRooms[department].Count != 0)
            {
                roomCode = departmentRooms[department].Keys.Last();
            }
            if (!departmentRooms[department].ContainsKey(roomCode))
            {
                departmentRooms[department][roomCode] = new List<string>();
            }

            if (departmentRooms[department][roomCode].Count() >= 3)
            {
                roomCode++;
                if (departmentRooms[department].Keys.Last() <= 19)
                {
                    departmentRooms[department][roomCode] = new List<string>();
                }
                else
                {
                    goto Skipped;
                }
            }
            departmentRooms[department][roomCode].Add(patient);

            Skipped:
            if (!departments.ContainsKey(department))
            {
                departments[department] = new List<string>();
            }
            departments[department].Add(patient);
            if (!doctors.ContainsKey(doctorName))
            {
                doctors[doctorName] = new List<string>();
            }
            doctors[doctorName].Add(patient);

            input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
        var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        while (command[0].ToLower() != "end")
        {
            if (command.Length == 1)
            {
                var searchDepartment = command[0];
                Console.WriteLine(string.Join("\n", departments[searchDepartment]));
            }
            else if (command.Length == 2)
            {
                int room;
                bool isDepartmentRoomCommand = int.TryParse(command[1], out room);

                if (isDepartmentRoomCommand)
                {
                    var deparmentSearch = command[0];
                    Console.WriteLine(string.Join("\n", departmentRooms[deparmentSearch][room].OrderBy(x => x)));
                }
                else
                {
                    var searchDoctor = string.Join(" ", command);
                    Console.WriteLine(string.Join("\n", doctors[searchDoctor].OrderBy(x => x)));
                }
            }
            command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}