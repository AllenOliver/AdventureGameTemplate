using UnityEngine;
using System.Collections;

public static class BoxCollider2DExtensions 
{

    public static void On(this BoxCollider2D box) => box.enabled = true;
    public static void Off(this BoxCollider2D box) => box.enabled = false;

    public static IEnumerator TimedDeactivate(this BoxCollider2D box,float time)
    {
        box.Off();
        yield return new WaitForSeconds(time);
        box.On();
    } 
}
