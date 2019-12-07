using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "NewEnemyData", menuName ="Tools/Create New Enemy", order =251)]
public class EnemyData : ScriptableObject
{
    public string EnemyName;
    public int MaxHP;

}
