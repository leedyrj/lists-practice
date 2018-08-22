using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            //             Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            // Create another List that contains that last two planet of our solar system.
            List<string> newPlanetList = new List<string>() { "Neptune", "Uranus" };
            // Combine the two lists by using AddRange().
            planetList.AddRange(newPlanetList);
            // Use Insert() to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            // Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");

            foreach (string item in rockyPlanets)
            {
                Console.WriteLine(item);
            }

            foreach (string item in planetList)
            {
                Console.WriteLine(item);
            }

            // Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the name of the planet that it has visited. If it visited more than one planet, just pick one.
            // List<Dictionary<string, string>> satellites = new List<Dictionary<string, string>>();

            // satellites.Add(new Dictionary<string, string>());
            // satellites[0].Add("Mercury", "Messenger");
            // satellites[0].Add("Venus", "Mariner, Venera");
            // satellites[0].Add("Mars", "Viking, Opportunity, Curiosity");


            // foreach (Dictionary<string, string> item in satellites)
            // {
            //     foreach (KeyValuePair<string, string> thing in item)
            //     {
            //         Console.WriteLine("{0} visited by {1}", thing.Key, thing.Value);
            //     }
            // }

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

            Dictionary<string, string> Viking = new Dictionary<string, string>(){
                {"Mars", "Viking"}
            };

            Dictionary<string, string> Opportunity = new Dictionary<string, string>(){
                {"Mars", "Opportunity"}
            };

            probes.Add(Viking);
            probes.Add(Opportunity);

            foreach (string planet in planetList)
            {
                List<string> visitedProbes = new List<string>();
                foreach (Dictionary<string, string> probe in probes)
                {
                    if (probe.ContainsKey(planet))
                    {
                        visitedProbes.Add(probe[planet])
                    };
                }
                Console.WriteLine($"{planet}: {String.Join(",", visitedProbes)}");
            }

            // Iterate over your list of planets from above, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.

        }
    }
}
