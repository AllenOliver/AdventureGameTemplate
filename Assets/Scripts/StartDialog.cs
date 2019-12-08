using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartDialog : MonoBehaviour
{
    public DialogData Dialog;

    private string[] DialogLines;
    private bool talking;

    public void StartTalking()
    {

        DialogLines = Dialog.Sentences;

        Globals.CanMove = false;
        if (Dialog != null)
            StartCoroutine(DialogRoutine());
        
    }

    public IEnumerator DialogRoutine()
    {
        talking = true;
        UpdateDialogUI.OpenPanel();
        yield return new WaitForSeconds(.25f);
        if(talking)
        {
            for (int i = 0; i < DialogLines.Length; i++)
            {
                UpdateDialogUI.UpdateDialogUIPanel(DialogLines[i], Dialog.CharacterPortrait);
                yield return new WaitForSeconds(2f);
                //yield return new WaitUntil(() => UpdateDialogUI.main.Typing = false);
                UpdateDialogUI.UpdateDialogUIPanel("", Dialog.CharacterPortrait);
                yield return new WaitForSeconds(1f);
            }
            EndDialog();
        }
    }

    private void EndDialog()
    {
        talking = false;
        Globals.CanMove = true;
        //call ui close function
        UpdateDialogUI.ClosePanel();
    }
}
