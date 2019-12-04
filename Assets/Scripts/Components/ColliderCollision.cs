using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class ColliderCollision : MonoBehaviour
{

    public UnityEvent OnCollide = new UnityEvent();
    public string Tag;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == tag)
            OnCollide?.Invoke();
    }
}
