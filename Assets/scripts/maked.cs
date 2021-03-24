using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maked : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hit)
    {
        Player Player = hit.GetComponent<Player>();
        if (Player != null)
        {
            Player.TakeDamage(1);
        }
        Destroy(gameObject);
    }
}
