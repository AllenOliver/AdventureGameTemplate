using UnityEngine;

[CreateAssetMenu(fileName = "NewDialog", menuName = "Tools/Create New Dialog Object", order = 251)]
public class DialogData : ScriptableObject
{
    [Header("Be carful about string sizes. Play it safe and go to the next line")]
    [TextArea]
    public string[] Sentences;
    public Sprite CharacterPortrait;
}