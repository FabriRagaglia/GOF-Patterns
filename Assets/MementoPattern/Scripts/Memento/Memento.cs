using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern
{
    public class Memento : MonoBehaviour
    {
        private Checkpoints _state;

        public Memento (Checkpoints state)
        {
            _state = state;
        }

        public Checkpoints GetState()
        {
            return _state;
        }
    }
}
