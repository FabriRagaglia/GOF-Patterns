using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypePattern { 
    public abstract class CarPrototype
    {
        protected string _color;
        protected string _modelo;

        public string color { set => _color = value; }
        public string modelo { set => _modelo = value; }

        public abstract CarPrototype Clonar();
        public abstract string ShowCar();
    }
}
