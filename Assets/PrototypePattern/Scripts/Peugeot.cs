using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypePattern { 
    public class Peugeot : CarPrototype
    {
        public override CarPrototype Clonar()
        {
            return (Peugeot)this.MemberwiseClone();
        }

        public override string ShowCar()
        {
            return $"Fiat modelo: {_modelo} color: {_color}";
        }
    }
}
