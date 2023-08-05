using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FecadePattern { 
    public class UIFade : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup;   
        
        public void Show()
        {
            _canvasGroup.alpha = 1;
        }

        public void Hide()
        {
            _canvasGroup.alpha = 0;
        }
    }
}
