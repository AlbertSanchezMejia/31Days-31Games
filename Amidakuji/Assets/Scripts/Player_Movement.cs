using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] float adding;
    [SerializeField] float maxRight;
    [SerializeField] float maxLeft;
    bool canMove;

    void Start()
    {
        canMove = true;
    }

    void Update()
    {
        if(canMove == false)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && canGoR())
        {
            transform.position += (Vector3.right * adding);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && canGoL())
        {
            transform.position -= (Vector3.right * adding);
        }
    }

    bool canGoR()
    {
        return transform.position.x < maxRight;
    }
    bool canGoL()
    {
        return transform.position.x > maxLeft;
    }
}
