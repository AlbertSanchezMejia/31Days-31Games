using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Write : MonoBehaviour
{
    [SerializeField] string frase;
    [SerializeField] Text texto;
    [SerializeField] float delayText = 0.1f;
    bool isWriting;

    void Start()
    {
        StartCoroutine(WriteText(frase));
    }

    IEnumerator WriteText(string sentence)
    {
        isWriting = true;
        texto.text = "";

        foreach (char letra in sentence)
        {
            texto.text = texto.text + letra;
            yield return new WaitForSeconds(delayText);
        }
        isWriting = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && isWriting)
        {
            StopAllCoroutines();
            texto.text = frase;
        }
    }

}
