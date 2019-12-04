using UnityEngine;
using System.Collections;

public static class GameObjectExtension 
{
    public static void On(this GameObject go) => go.SetActive(true);

    public static void Off(this GameObject go) => go.SetActive(false);

    /// <summary>
    /// Activates the obect for a set amount of time; Then deactivates it.
    /// </summary>
    /// <param name="go">The Gameobject.</param>
    /// <param name="time">The time to stay active.</param>
    public static IEnumerator TimedActivate(this GameObject go, float time)
    {
        go.On();
        yield return new WaitForSeconds(time);
        go.Off();
    }
}
