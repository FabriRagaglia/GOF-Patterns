using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypePattern
{
    public class Fiat : CarPrototype
    {
        public override CarPrototype Clonar()
        {
            return (Fiat)this.MemberwiseClone();
        }

        public override string ShowCar()
        {
            return $"Fiat modelo: {_modelo} color: {_color}";
        }
    }
}
