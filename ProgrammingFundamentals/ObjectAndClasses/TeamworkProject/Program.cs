using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamNumber = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < teamNumber; i++)
            {
                string[] input = Console.ReadLine().Split("-");
                string creator = input[0];
                string teamName = input[1];
                if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    teams.Add(new Team(creator, teamName));
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment") break;
                string[] inputArr = input.Split("->");
                string memberName = inputArr[0];
                string teamName = inputArr[1];
                if(!teams.Any(x=>x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(x => x.members.Contains(memberName)) || teams.Any(x=>x.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                else
                {
                    teams.Find(x => x.Name == teamName).AddMember(memberName);
                }
            }
            teams = teams.OrderBy(x => x.Name).ToList();
            foreach (var team in teams)
            {
                if (team.members.Count != 0)
                {
                    Console.WriteLine(team.Name);
                    Console.WriteLine($"- {team.Creator}");
                    foreach (var member in team.members)
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teams)
            {
                if (team.members.Count == 0)
                {
                    Console.WriteLine(team.Name);
                }
            }
        }
    }
    class Team
    {
        public Team(string creator, string name)
        {
            Creator = creator;
            Name = name;
        }

        public string Creator { get; }
        public string Name { get; }

        public List<String> members = new List<string>();

        public void AddMember(string memberName)
        {
            members.Add(memberName);
        }
    }
}
