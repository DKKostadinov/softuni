using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Dictionary<string, int> road_numberOfRacers= new Dictionary<string, int>();
            Dictionary<string, List<string>> road_listOfRacers = new Dictionary<string, List<string>>();
            while (true)
            {
                input = Console.ReadLine();
                if (input == "END")
                {
                    foreach (var kvp in road_listOfRacers)
                    {
                        road_numberOfRacers.Add(kvp.Key, kvp.Value.Count);
                    }
                    IOrderedEnumerable<KeyValuePair<string, int>> sortedCollection = road_numberOfRacers
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key);
                    Console.WriteLine("Practice sessions:");
                    road_numberOfRacers.OrderBy(x => x.Value).Select(x => x.Key);
                    foreach (var kvp in sortedCollection)
                    {
                        Console.WriteLine(kvp.Key);
                        foreach (var racer in road_listOfRacers[kvp.Key])
                        {
                            Console.WriteLine("++" + racer);
                        }
                    }
                    return;
                }
                List<string> commandInput = input.Split("->").ToList();
                string command = commandInput[0];
                switch (command)
                {
                    case "Add":
                        {
                            string road = commandInput[1];
                            string addRacer = commandInput[2];
                            if (!road_listOfRacers.ContainsKey(road))
                            {
                                List<string> listOfRacer = new List<string>();
                                listOfRacer.Add(addRacer);
                                road_listOfRacers.Add(road, listOfRacer);
                            }
                            else
                            {
                                List<string> listOfRacers = road_listOfRacers[road];
                                listOfRacers.Add(addRacer);
                                road_listOfRacers[road] = listOfRacers;
                            }
                            break;
                        }
                        
                    case "Move":
                        {
                            string currentRoad = commandInput[1];
                            string moveRacer = commandInput[2];
                            string nextRoad = commandInput[3];
                            if (road_listOfRacers[currentRoad].Contains(moveRacer))
                            {
                                List<string> firstRoadList = road_listOfRacers[currentRoad];
                                List<string> secondRoadList = road_listOfRacers[nextRoad];
                                firstRoadList.Remove(moveRacer);
                                secondRoadList.Add(moveRacer);
                                road_listOfRacers[currentRoad] = firstRoadList;
                                road_listOfRacers[nextRoad] = secondRoadList;
                            }
                            break;
                        }
                        
                    case "Close":
                        string roadToClose = commandInput[1];
                        road_listOfRacers.Remove(roadToClose);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
