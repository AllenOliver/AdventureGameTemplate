using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
    public int MaxHP; //Will more than likely be pulled from a data source
    public int CurrentHP; //Will more than likely be pulled from a data source

    /// <summary>
    /// Deducts damage; Returns true if current hp <= 0.
    /// </summary>
    /// <param name="dmg">The amount of damage its taking.</param>
    /// <returns></returns>
    public bool TakeHit(int dmg)
    {
        CurrentHP -= dmg;

        if (CurrentHP <= 0)
            return true;
        else
            return false;
    }

    /// <summary>
    /// Heals the specified amount.
    /// </summary>
    /// <param name="Amount">The amount.</param>
    public void Heal(int Amount)
    {
        CurrentHP += Amount;
        if (CurrentHP >= MaxHP)
        {
            CurrentHP = MaxHP;
        }
    }

}
