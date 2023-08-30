using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IProxiPattern
{
    [CreateAssetMenu(fileName ="Equipment name (proxy)", menuName =("Proxy/Armor"), order =0)]
    public class Armor : ScriptableObject, IEquipment
    {
        [SerializeField] private string _equipmentName;

        public void ReadEquipmentData()
        {
            Debug.Log($"This Armor is {_equipmentName}");
        }
    }
}
