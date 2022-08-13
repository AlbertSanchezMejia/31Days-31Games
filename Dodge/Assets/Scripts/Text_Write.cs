using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Write : MonoBehaviour
{
    [SerializeField] string frase;
    [SerializeField] Text texto;
    [SerializeField] float delayText = 0.1f;
    bool isRunning;

    void Start()
    {
        StartCoroutine(Reloj());
    }

    IEnumerator Reloj()
    {
        isRunning = true;
        texto.text = "";

        foreach (char letra in frase)
        {
            texto.text = texto.text + letra;
            yield return new WaitForSeconds(delayText);
        }
        isRunning = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && isRunning)
        {
            StopAllCoroutines();
            texto.text = frase;
        }
    }

}
