using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_ : MonoBehaviour
{
    [SerializeField] float limitTime;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (limitTime > 0) { limitTime -= Time.deltaTime; }
        else
        {
            Debug.Log("Perdiste");
            Time.timeScale = 0;
        }
    }


}
