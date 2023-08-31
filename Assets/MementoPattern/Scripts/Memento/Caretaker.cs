using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementoPattern
{
    public class Caretaker : MonoBehaviour
    {
        private List<Memento> _mementos = new();

        public void AddMemento(Memento memento)
        {
            _mementos.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return _mementos[index];
        }
    }
}
