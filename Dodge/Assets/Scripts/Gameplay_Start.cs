using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay_Start : MonoBehaviour
{
    [SerializeField] Spawn_ spawner;
    void Awake()
    {
        spawner.enabled = false;
    }

    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            spawner.enabled = true;
            gameObject.SetActive(false);
        }
    }

}
