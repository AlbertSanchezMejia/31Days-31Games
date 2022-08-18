using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Pause : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = (Time.timeScale == 1) ? 0 : 1;
        }
    }

}
