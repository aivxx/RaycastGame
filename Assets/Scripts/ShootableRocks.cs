using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootableRocks : MonoBehaviour
{
    public int currentHealth = 2;

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <=0)
        {
            gameObject.SetActive(false);
        }
    }
}
