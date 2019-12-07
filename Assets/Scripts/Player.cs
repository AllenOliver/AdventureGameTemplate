
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Public Fields
    [Range(0, 100)]
    public float Speed;
    [Range(0, 100)]
    public float JumpSpeed;
    public GameObject AttackObject;

    public static Player main { get; private set; }
    #endregion

    #region Private fields
    private Rigidbody2D rb;
    private Health health;
    private BoxCollider2D box;
    #endregion

    #region Unity Methods

    private void Awake()
    {
        main = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = GetComponent<Health>();
        box = GetComponent<BoxCollider2D>();
    }

    void Update() => Move();
    
    #endregion

    #region Private Methods

    private void Move()
    {
        if (Input.GetAxisRaw("Horizontal") >= .5f)
            rb.SlideRight(Speed, Time.deltaTime);

        if (Input.GetAxisRaw("Horizontal") <= -.5f)
            rb.SlideLeft(Speed, Time.deltaTime);

        if (Input.GetButtonDown("Attack"))
            Attack();
        
        if (Input.GetButtonDown("Jump"))
            rb.Jump(JumpSpeed);
    }

    private void Attack() => StartCoroutine(AttackObject.TimedActivate(.25f));
        

    public void TakeHit()
    {
        health.TakeHit(1);
        StartCoroutine(box.TimedDeactivate(.25f));
        //Flash
        UpdateHealthUI.UpdateHealth(health.MaxHP, health.CurrentHP);
    }

    public void HealPlayer(int amount)
    {
        health.Heal(amount);
        UpdateHealthUI.UpdateHealth(health.MaxHP, health.CurrentHP);
    }
    #endregion
}
