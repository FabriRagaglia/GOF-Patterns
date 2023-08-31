using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatern
{
    public class Installer : MonoBehaviour
    {
        [SerializeField] private HealthView _healthView;

        private Hero _hero;

        void Awake()
        {
            _hero = new Hero();
            _hero.Subscribe(_healthView);
            _hero.Notify();
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Q))
            {
                _hero.ApplyDamage(10);
            }
        }
    }
}
