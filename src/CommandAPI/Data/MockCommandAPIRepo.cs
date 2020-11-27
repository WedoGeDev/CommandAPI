using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                new Command {
                    Id = 0,
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    HowTo = "How to generate a migration",
                    Platform = ".Net Core EF"
                },
                new Command {
                    Id = 1,
                    CommandLine = "dotnet ef database update",
                    HowTo = "How to run migrations",
                    Platform = ".Net Core EF"
                },
                new Command {
                    Id = 2,
                    CommandLine = "dotnet ef migrations list",
                    HowTo = "List active migrations",
                    Platform = ".Net Core EF"
                }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0,
                CommandLine = "dotnet ef migrations add <Name of Migration>",
                HowTo = "How to generate a migration",
                Platform = ".Net Core EF"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}