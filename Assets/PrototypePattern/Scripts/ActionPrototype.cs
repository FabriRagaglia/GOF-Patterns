using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrototypePattern { 
    public class ActionPrototype : MonoBehaviour
    {
        private void Start()
        {
            CarPrototype fiat = new Fiat();
            CarPrototype peugeot = new Peugeot();

            var fiatPalio = fiat.Clonar();
            fiatPalio.modelo = "Palio fire";
            fiatPalio.color = "Black";
            Debug.Log(fiatPalio.ShowCar());

            var peugeot206 = peugeot.Clonar();
            peugeot206.modelo = "Peugeot 206";
            peugeot206.color = "Gray";
            Debug.Log(peugeot206.ShowCar());
        }

    }
}
