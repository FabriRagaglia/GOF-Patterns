using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CommandPattern { 

    public class UiButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private CanvasGroup _canvasGroupOut;
        [SerializeField] private CanvasGroup _canvasGroupIn;

        private void Awake()
        {
            _button.onClick.AddListener(ExecuteAnimation);
        }

        private void ExecuteAnimation()
        {
            CommandController.instance.AddCommand(new CanvasFadeCommand(_canvasGroupOut, 0, 0.5f));
            CommandController.instance.AddCommand(new CanvasFadeCommand(_canvasGroupIn, 1, 0.5f));
        }
    }
}
