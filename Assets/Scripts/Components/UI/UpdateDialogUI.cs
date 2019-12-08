

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UpdateDialogUI : MonoBehaviour
{
    public static TextMeshProUGUI DialogText;
    public static Image Portait;
    public static UpdateDialogUI main;

    private Animator anim;
    private void Awake()
    {
        if (main == null)
            main = this;

        DialogText = GetComponentInChildren<TextMeshProUGUI>();
        Portait = GetComponentInChildren<Image>();
        anim = GetComponentInParent<Animator>();
    }

    public static void OpenPanel() => main.anim.SetTrigger("Open");
    public static void UpdateDialogUIPanel(string text, Sprite portrait = null)
    {
        if (portrait != null)
        {
            Portait.gameObject.On(); 
            Portait.sprite = portrait;
        }
            
        else
            Portait.gameObject.Off();

        //main.StopCoroutine(TypeSentence(text));
        main.StartTyping(text);

    }

    public static void ClosePanel() => main.anim.SetTrigger("Close");

    void StartTyping(string text)
    {
        StartCoroutine(TypeSentence(text));
    }

     IEnumerator TypeSentence(string sentence)
    {
        DialogText.text = "";
        foreach (char letter in sentence)
        {
            DialogText.text += letter;
            yield return new WaitForSeconds(.01f);
        }
        //textSound.volume = Random.Range(.1f, .3f);
        //textSound.Play();
        yield break;
    }

}
