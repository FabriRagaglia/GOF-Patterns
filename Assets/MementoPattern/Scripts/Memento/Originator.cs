using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern { 
    public class Originator
    {
        private Checkpoints _state;

        public void SetState(Checkpoints state)
        {
            _state = state;
        }

        public Checkpoints GetState()
        {
            return _state;
        }

        public Memento save()
        {
            return new Memento(_state);
        }

        public void Load(Memento memento)
        {
            _state = memento.GetState();
        }
    }
}
