using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float moveDis;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            MoveObjectPosition(Vector3.forward * moveDis);
            return;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            MoveObjectPosition(-Vector3.forward * moveDis);
            return;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            MoveObjectPosition(Vector3.right * moveDis);
            return;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            MoveObjectPosition(-Vector3.right * moveDis);
        }
    }


    void MoveObjectPosition(Vector3 direction)
    {
        bool canMove = Physics.Raycast(transform.position + direction, -transform.up, 1f);
        if (canMove == false)
        {
            return;
        }
        rb.MovePosition(transform.position + direction);
    }

}
