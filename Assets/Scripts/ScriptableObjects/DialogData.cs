using UnityEngine;

[CreateAssetMenu(fileName = "NewDialog", menuName = "Tools/Create New Dialog Object", order = 251)]
public class DialogData : ScriptableObject
{
    [TextArea]
    public string[] Sentences;

    public Sprite CharacterPortrait;

}