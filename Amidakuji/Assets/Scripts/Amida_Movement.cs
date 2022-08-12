using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amida_Movement : MonoBehaviour
{
    [SerializeField] float speed;
    bool isChanging;
    Rigidbody2D rb;
    Quaternion startRotation;
    bool canMove;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startRotation = transform.rotation;
        isChanging = false;
        canMove = false;
    }

    void FixedUpdate()
    {
        if(canMove == false)
        {
            return;
        }
        rb.velocity = (transform.up * speed * Time.fixedDeltaTime * 10);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Road"))
        {
            transform.position = collision.transform.position;

            if(isChanging == false)
            {
                transform.rotation = collision.transform.rotation;
                isChanging = true;
                return;
            }

            transform.rotation = startRotation;
            isChanging = false;
        }
    }

}
