using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.EventArguments
{
    public class GameMessagesEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public GameMessagesEventArgs(string message)
        {
            Message = message;
        }
    }
}
