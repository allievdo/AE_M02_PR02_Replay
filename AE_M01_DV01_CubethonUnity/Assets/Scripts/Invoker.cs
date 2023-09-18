using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Invoker
{
    private Command _Command;
    public bool disableLog = false;

    public void SetCommand(Command command)
    {
        _Command = command;
    }

    public void ExecuteCommand()
    {
        if (!disableLog)
        {
            CommandLog.commands.Enqueue(_Command);
        }
        _Command.Execute();
    }
}