using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Characterrestriction : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject startbutton;

    void Start()
    {
        inputField.onValueChanged.AddListener(CheckInputLength);
    }

    void CheckInputLength(string input)
    {
        if (input.Length > 1 && input.Length <8)
        {
            Debug.Log("Á¤»ó");
            startbutton.SetActive(true);

        }
        else
            startbutton.SetActive(false);
    }

}
