using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AbstractFactoryPattern { 
    public abstract class Weapon : MonoBehaviour
    {
        [field: SerializeField] public string id { get; set; }
    }
}
