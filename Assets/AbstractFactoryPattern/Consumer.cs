using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern { 
    public class Consumer : MonoBehaviour
    {
        private ObjectsFactory _currentObjectFactory;

        public void Configure(ObjectsFactory objectFactory)
        {
            _currentObjectFactory = objectFactory;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                _currentObjectFactory.CreateEnemy("Warrior");
            }

            if (Input.GetKeyDown(KeyCode.F2))
            {
                _currentObjectFactory.CreateEnemy("Archer");
            }

            if (Input.GetKeyDown(KeyCode.F3))
            {
                _currentObjectFactory.CreateWeapon("Sword");
            }

            if (Input.GetKeyDown(KeyCode.F4))
            {
                _currentObjectFactory.CreateWeapon("Bow");
            }
        }
    }
}
