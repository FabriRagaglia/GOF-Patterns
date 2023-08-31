using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern
{
    public class CheckPointController : MonoBehaviour
    {
        void Start()
        {
            var caretaker = new Caretaker();
            var originator = new Originator();

            var checkPoint = new Checkpoints();
            checkPoint.SetCheckPointName("Initial Position");
            checkPoint.SetCheckpointIndex(0);
            originator.SetState(checkPoint);

            checkPoint = new Checkpoints();
            checkPoint.SetCheckPointName("Medium Position");
            checkPoint.SetCheckpointIndex(1);
            originator.SetState(checkPoint);

            caretaker.AddMemento(originator.save());

            checkPoint = new Checkpoints();
            checkPoint.SetCheckPointName("End Position");
            checkPoint.SetCheckpointIndex(2);
            originator.SetState(checkPoint);

            checkPoint = new Checkpoints();
            checkPoint.SetCheckPointName("Victory Position");
            checkPoint.SetCheckpointIndex(3);
            originator.SetState(checkPoint);

            checkPoint = originator.GetState();
            Debug.Log($"last state: {checkPoint.ToString()}");

            Debug.Log($"load state");
            originator.Load(caretaker.GetMemento(0));
            checkPoint = originator.GetState();
            Debug.Log($"last state: {checkPoint.ToString()}");
        }
    }
}
