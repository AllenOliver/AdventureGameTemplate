

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpdateDialogUI : MonoBehaviour
{
    public static TextMeshProUGUI DialogText;
    public static Image Portait;

    private void Awake()
    {
        DialogText = GetComponent<TextMeshProUGUI>();
        Portait = GetComponent<Image>();
    }

    public static void OpenPanel()
    {

    }
    public static void UpdateDialogUIPanel(string text, Sprite portrait = null)
    {
        if (portrait != null)
        {
            Portait.gameObject.On(); 
            Portait.sprite = portrait;
        }
            
        else
            Portait.gameObject.Off();

        DialogText.text = text;

    }

    public static void ClosePanel()
    {

    }

}
