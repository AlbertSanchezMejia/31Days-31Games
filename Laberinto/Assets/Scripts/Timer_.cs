using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer_ : MonoBehaviour
{
    [SerializeField] float timer;
    [SerializeField] Text texto;


    void Update()
    {
        timer -= Time.deltaTime;
        texto.text = timer.ToString("F1");
        if (timer <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

}
