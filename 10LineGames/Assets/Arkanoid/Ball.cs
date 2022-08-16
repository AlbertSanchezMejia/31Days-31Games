using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float startSpeed = 4f;
    [SerializeField] Rigidbody2D rb;
    void Start()
    {
        Launch();
    }
    void Launch()
    {
        float xSpeed = Random.Range(0, 2) == 0 ? -1 : 1;
        float ySpeed = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(1, ySpeed) * startSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            rb.velocity *= 1.05f;
        }
    }
}
