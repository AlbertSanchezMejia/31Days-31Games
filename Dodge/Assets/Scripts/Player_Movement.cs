using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    float xMov;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        xMov = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        float movementX = xMov * speed * Time.fixedDeltaTime * 10;
        rb.velocity = new Vector2(movementX, rb.velocity.y);
    }

}
