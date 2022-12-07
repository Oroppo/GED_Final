using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCommand : ICommand
{
    Transform Position;

    public CollectCommand(Transform pos)
    {
        Position = pos;
    }

    public void Execute()
    {
        CoinCounter._instance.IncreaseCount();
        CommandBrain._instance.DoCommand(this);
    }
    public void Undo()
    {
        CoinCounter._instance.DecreaseCount();
        CommandBrain._instance.UndoCommand(this);
    }

}
