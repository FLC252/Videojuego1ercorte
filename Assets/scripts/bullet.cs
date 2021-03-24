using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 12f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        caja caja = hit.GetComponent<caja>();
        if (caja != null)
        {
            caja.TakeDamage(1);
        }
        Destroy(gameObject);
    }

}
