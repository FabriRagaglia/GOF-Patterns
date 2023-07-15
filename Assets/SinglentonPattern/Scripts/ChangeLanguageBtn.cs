using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Button))]
public class ChangeLanguageBtn : MonoBehaviour
{
    private Button _button;
    private TextMeshProUGUI _text;

    void Start()
    {
        _button = GetComponent<Button>();
        _text = GetComponentInChildren<TextMeshProUGUI>();
        _button.onClick.AddListener(ChangeLanguage);

        var instance = LanguageController.GetInstance();
        var currentLanguage = instance.GetCurrentLanguage();
        _text.text = currentLanguage ? "Cambiar idioma" : "Change Language";
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(ChangeLanguage);
    }

    private void ChangeLanguage()
    {
        var instance = LanguageController.GetInstance();
        instance.ChangeLanguage();

        var currentLanguage = instance.GetCurrentLanguage();
        _text.text = currentLanguage ? "Cambiar idioma" : "Change Language";
    }
}
