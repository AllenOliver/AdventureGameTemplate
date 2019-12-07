using UnityEngine;
using System.Collections;

public class HealthPickup : Coin
{

    public override void PickUp()
    {
        gameObject.Off();

        Player.main.HealPlayer(1);
        
    }
}
