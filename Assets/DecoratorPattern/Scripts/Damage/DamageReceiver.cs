using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Decorator 
{
    public class DamageReceiver : MonoBehaviour, IDamageReceiver
    {
        [SerializeField] private TextMeshProUGUI[] _damageTexts;
        private int _lastTextused;

        private void Awake()
        {
            foreach (var text in _damageTexts)
            {
                text.SetText(string.Empty);
            }
        }

        public void ReceiveDamage(int damage, Color color)
        {
            var textIndex = GetTextIndexToUse();

            _damageTexts[textIndex].SetText(damage.ToString());
            _damageTexts[textIndex].color = color;

            _lastTextused = textIndex;
        }

        private int GetTextIndexToUse()
        {
            return (_lastTextused + 1) % _damageTexts.Length;
        }
    }
}
