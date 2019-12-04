using UnityEngine;
using System.Collections;

public static class Rigidbody2DExtensions
{

    public static void SlideRight(this Rigidbody2D rb, float speed, float deltaTime) => 
        rb.velocity = new Vector2(speed * deltaTime, rb.velocity.y);
    public static void SlideLeft(this Rigidbody2D rb, float speed, float deltaTime) => 
        rb.velocity = new Vector2(-speed * deltaTime, rb.velocity.y);
    public static void Jump(this Rigidbody2D rb, float speed) => 
        rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);

}
