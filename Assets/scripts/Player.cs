using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Character controller;
    float xMove = 0f;
    public float runSpeed = 40f;
    public bool jump = false;
    public Animator animator;
    bool attack; 
    public int health = 4;
    public GameObject death;

    public void TakeDamage(int damage)
    {
        health = health - damage;

        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        SceneManager.LoadScene("die");
        Destroy(gameObject);
    }

    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("speed", Mathf.Abs(xMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    void Attack()
    {
        if (attack) { 
        animator.SetTrigger("attack");
        }
    }
    void FixedUpdate()
    {
        controller.Move(xMove * Time.fixedDeltaTime, false, jump);

        jump = false;
    }
}
