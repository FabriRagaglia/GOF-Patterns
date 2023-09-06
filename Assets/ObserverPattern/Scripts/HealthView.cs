using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ObserverPatern
{
    public class HealthView : MonoBehaviour, Observer
    {
        [SerializeField] private TextMeshProUGUI _health;

        public void UpdateObserver(Subject subject)
        {
            if(subject is Hero hero)
            {
                _health.SetText(hero.health.ToString());
            }
        }
    }
}
