using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_State : MonoBehaviour
{
    [SerializeField] Amida_Movement amida;
    [SerializeField] Player_Movement horizontal;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            horizontal.canMove = false;
            amida.canMove = true;
        }
    }

}
