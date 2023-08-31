using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace CommandPattern
{
    public class CanvasFadeCommand : ICommand
    {
        private readonly CanvasGroup _canvasGroup;
        private readonly float _newAlpha;
        private readonly float _duration;

        public CanvasFadeCommand(CanvasGroup canvasGroup, float newAlpha, float duration)
        {
            _canvasGroup = canvasGroup;
            _newAlpha = newAlpha;
            _duration = duration;
        }

        public async Task Execute()
        {
            var initAlpha = _canvasGroup.alpha;
            var alphaDifference = _newAlpha - initAlpha;
            var alphaIncrement = alphaDifference / _duration;

            while(Mathf.Abs(_canvasGroup.alpha - _newAlpha) > 0.01)
            {
                _canvasGroup.alpha += alphaIncrement * Time.deltaTime;
                await Task.Yield();
            }
        }
    }
}
