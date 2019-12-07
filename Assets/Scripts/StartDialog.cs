using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StartDialog : MonoBehaviour
{
    public DialogData Dialog;
    public Queue<string> DialogLines;

    private bool talking;
    public void StartTalking()
    {
        if (DialogLines.Count > 0) //empty queue if it has items in it 
            DialogLines.Clear(); 

        foreach(var line in Dialog.Sentences) //add all to  queue
            DialogLines.Enqueue(line);
        

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
            UpdateDialogUI.UpdateDialogUIPanel(getSentence(), Dialog.CharacterPortrait);
            yield return new WaitUntil(() => Input.GetButtonDown("Attack"));
        }
    }


    private string getSentence()
    {
        //check for empty queue and return
        if (DialogLines.Count == 0)
        {
            EndDialog();
            return "";
        }
        return DialogLines.Dequeue(); //Get Next Sentence from the queue
    }

    private void EndDialog()
    {
        talking = false;
        Globals.CanMove = true;
        //call ui close function

        UpdateDialogUI.ClosePanel();
    }


}
