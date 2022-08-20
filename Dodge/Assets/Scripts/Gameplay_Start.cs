using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay_Start : MonoBehaviour
{
    [SerializeField] Spawn_ spawner;
    [SerializeField] Shake_Object shaker;
    [SerializeField] GameObject startText;
    [SerializeField] GameObject timer;

    void Awake()
    {
        spawner.enabled = false;
        shaker.enabled = false;
        startText.SetActive(true);
    }

    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            spawner.enabled = true;
            shaker.enabled = true;
            timer.SetActive(true);
            startText.SetActive(false);
            gameObject.SetActive(false);
        }
    }

}
