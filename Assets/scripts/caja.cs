using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja : MonoBehaviour
{
    public int health = 3;
    public GameObject death;

    public void TakeDamage(int damage)
    {
        health = health - damage;

        if(health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        
        Destroy(gameObject);
    }
}
