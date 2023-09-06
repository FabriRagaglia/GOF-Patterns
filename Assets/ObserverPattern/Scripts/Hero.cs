using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatern
{
    public class Hero : Subject
    {
        public int health { get; private set; }

        private readonly List<Observer> _observers;

        public Hero()
        {
            _observers = new();
            health = 100;
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.UpdateObserver(this);
            }
        }

        public void Subscribe(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void ApplyDamage(int damage)
        {
            health -= damage;
            Notify();
        }
    }
}
