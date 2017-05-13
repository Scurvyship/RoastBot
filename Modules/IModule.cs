using System.Collections.Generic;

namespace RoastBot.Modules
{
    internal interface IModule
    {
        void HandleCommand(IEnumerable<string> args);
    }
}
