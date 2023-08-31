using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatern { 
    public interface Subject
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
        void Notify();
    }
}
