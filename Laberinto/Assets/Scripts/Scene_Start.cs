using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Start : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject timer;

    void Start()
    {
        Player.SetActive(false);
        timer.SetActive(false);
    }

    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") !=0 || Input.GetAxisRaw("Vertical") != 0)
        {
            Player.SetActive(true);
            timer.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}
