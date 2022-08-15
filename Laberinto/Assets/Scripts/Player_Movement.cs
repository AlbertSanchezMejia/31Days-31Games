using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float moveDis;
    [SerializeField] float speed;
    Rigidbody rb;
    float xMov;
    float zMov;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            MovePosition(Vector3.forward * moveDis);
            return;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            MovePosition(-Vector3.forward * moveDis);
            return;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            MovePosition(Vector3.right * moveDis);
            return;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            MovePosition(-Vector3.right * moveDis);
        }*/
        xMov = Input.GetAxisRaw("Horizontal");
        zMov = Input.GetAxisRaw("Vertical");
    }

    void MovePosition(Vector3 direction)
    {
        rb.velocity = (new Vector3(xMov, rb.velocity.y, zMov) * speed * Time.fixedDeltaTime * 10);
    }

}
