using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IProxiPattern 
{
    [CreateAssetMenu(fileName = "Equipment name (proxy)", menuName = ("Proxy/Weapon"), order = 0)]
    public class WeaponEquipment : ScriptableObject, IEquipment
    {
        [SerializeField] private string _name;
        public void ReadEquipmentData()
        {
            Debug.Log($"This weapon is {_name}");
        }
    }
}
