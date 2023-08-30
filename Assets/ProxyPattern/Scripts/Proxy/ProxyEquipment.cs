using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IProxiPattern 
{
    public class ProxyEquipment : MonoBehaviour, IEquipment
    {
        public IEquipment _equipment;

        public void SetEquipment(IEquipment equipment)
        {
            _equipment = equipment;
        }

        public void ReadEquipmentData()
        {
            _equipment.ReadEquipmentData();
        }
    }
}
