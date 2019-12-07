using UnityEngine;
using System.Collections;

/// <summary>
/// Class encapsulating start functions and overall scene managment 
/// </summary>
public class GameManager: MonoBehaviour
{
    Player player;
    public static GameManager main;

    private void Awake()
    {
        main = this;
    }
    void Start()
    {
        player = FindObjectOfType<Player>();
        UpdateHealthUI.UpdateHealth(player.GetComponent<Health>().MaxHP, player.GetComponent<Health>().CurrentHP);
        UpdateCoinUI.UpdateCoinText(Globals.Coins);
    }




}
