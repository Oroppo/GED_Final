using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandBrain : MonoBehaviour
{
    private Queue<ICommand> CommandQueue;

    private List<ICommand> CommandHistory;

    static public CommandBrain _instance;

    private void Start()
    {
        if (_instance ==null)
        _instance = new CommandBrain();
    }
    private void Update()
    {
        if (CommandQueue.Count > 0)
        {

        }
    }
    public void UndoCommand(ICommand command)
    {
        CommandQueue.Dequeue();
        CommandHistory.Add(command);
    }
    public void DoCommand(ICommand command)
    {
        CommandQueue.Enqueue(command);
        CommandHistory.Add(command);
    }

}
