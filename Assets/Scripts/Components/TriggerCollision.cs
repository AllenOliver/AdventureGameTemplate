using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class TriggerCollision: MonoBehaviour
{
    public UnityEvent OnTrigger = new UnityEvent();
    public string Tag;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == tag)
            OnTrigger?.Invoke();
    }

}
