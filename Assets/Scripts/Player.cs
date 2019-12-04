
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
    #endregion

    #region Private fields
    private Rigidbody2D rb;
    private Health health;
    #endregion

    #region Unity Methods
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = GetComponent<Health>();
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
        

    private void TakeHit()
    {
        health.TakeHit(1);
        //Todo Update ui maybe?
    }

    #endregion
}
