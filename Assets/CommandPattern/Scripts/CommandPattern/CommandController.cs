using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace CommandPattern
{
    public class CommandController : MonoBehaviour
    {
        public static CommandController instance => _instance ?? (_instance = new CommandController());
        
        private static CommandController _instance;
        private readonly Queue<ICommand> _commandsToExecute;
        private bool _runningCommand;

        private CommandController()
        {
            _commandsToExecute = new ();
            _runningCommand = false;
        }

        private async Task RunNextCommand()
        {
            if (_runningCommand) return;
    
            while(_commandsToExecute.Count > 0)
            {
                _runningCommand = true;
                var commandToExecute = _commandsToExecute.Dequeue();
                await commandToExecute.Execute();
            }

            _runningCommand = false;
        }

        public void AddCommand(ICommand commandToEnqueue) 
        {
            _commandsToExecute.Enqueue(commandToEnqueue);
            RunNextCommand();
        }

    }
}
