using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LanguageController : MonoBehaviour
{
    //We create the same class statica to be able to access it without reference
    private static LanguageController _instance;
    
    public Action changeLanguageEvt;

    private bool _isSpanish = true;

    //We create an empty and private constructor so that the class cannot be instantiated from another script
    private LanguageController() { }

    private void Awake()
    {
        //We make sure that there is only one instance of class
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
            return;
        }

        Destroy(this);
    }
    
    //We create a function that returns the instance so that we can access its properties.
    //This is not 100 percent necessary since we can have the public class but in this case we handle it with getter.
    public static LanguageController GetInstance()
    {
        return _instance;
    }

    public void ChangeLanguage()
    {
        _isSpanish = _isSpanish == false;
        changeLanguageEvt.Invoke();
    }

    public bool GetCurrentLanguage()
    {
        return _isSpanish;
    }
}
