using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ShowLanguageText : MonoBehaviour
{
    private TextMeshProUGUI _text;

    private void Start()
    {
        var instance = LanguageController.GetInstance();
        instance.changeLanguageEvt += UpdateTittle;

        _text = GetComponent<TextMeshProUGUI>();

        UpdateTittle();
    }

    private void OnDestroy()
    {
        var instance = LanguageController.GetInstance();
        instance.changeLanguageEvt -= UpdateTittle;
    }

    private void UpdateTittle()
    {
        var isSpanish = LanguageController.GetInstance().GetCurrentLanguage();
        _text.text = isSpanish ? "Español" : "English";
    }
}
