using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POSTFIX = "Command";
        public string Read(string args)
        {
            
            string[] cmdTokens = args
                .Split(" "
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string commandName = cmdTokens[0] + COMMAND_POSTFIX;
            string[] commandArgs = cmdTokens
                .Skip(1)
                .ToArray();
            Assembly assembly = Assembly.GetCallingAssembly();
            Type[] types = assembly
                .GetTypes();
            Type typeToCreate = types.FirstOrDefault(t => t.Name == commandName);

            if (typeToCreate == null)
            {
                throw new InvalidOperationException("Invalid Command Type!");
                
            }

            Object instance = Activator
                .CreateInstance(typeToCreate);
            ICommand command = (ICommand) instance;
            string result = command.Execute(commandArgs);
            return result;
        }
    }
}