using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints
{
    private string _checkpointName;
    private int _checkpointIndex;

    public int GetCheckpointIndex()
    {
        return _checkpointIndex;
    }

    public void SetCheckpointIndex(int index)
    {
        _checkpointIndex = index;
    }

    public string GetCheckpointName()
    {
        return _checkpointName;
    }

    public void SetCheckPointName(string name)
    {
        _checkpointName = name;
    }

    public override string ToString()
    {
        return $"Checkpoint: Nombre {_checkpointName} - Index {_checkpointIndex}";
    }
}
