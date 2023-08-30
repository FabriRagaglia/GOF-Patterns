using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IProxiPattern {
    public class ButtonsUI : MonoBehaviour
    {
        [SerializeField] private ProxyEquipment _proxyEquipment;
        [SerializeField] ScriptableObject _equipmentData;

        public void ExucuteBtn() 
        {
            if(_proxyEquipment == null)
            {
                Debug.LogError("The proxy is null");
                return;
            }

            if(_equipmentData == null)
            {
                Debug.LogError($"The data is null");
                return;
            }

            if (_equipmentData is not IEquipment equipment)
            {
                Debug.LogError("The data is not IEquipment");
                return;
            }

            _proxyEquipment.SetEquipment(equipment);
            _proxyEquipment.ReadEquipmentData();

        }

    }
}
