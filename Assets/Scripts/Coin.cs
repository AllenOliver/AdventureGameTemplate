using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
    [Range(1,5)]
    public int CoinHop;

    private Rigidbody2D rb;
    private int Value;
    // Use this for initialization
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.Jump(Random.Range(CoinHop * .3f, CoinHop * 1.2f));
        Value = Random.Range(1, 5);
    }

   public virtual void PickUp()
    {
        gameObject.Off();

        Globals.Coins += Value;
        UpdateCoinUI.UpdateCoinText(Globals.Coins);
        //Play sound
        //particles
    }

}
