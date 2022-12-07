using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    abstract void Execute();
    abstract void Undo();

}
