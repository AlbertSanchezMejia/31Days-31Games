using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Write : MonoBehaviour
{
    [SerializeField] Text texto;
    [SerializeField] GameObject arrowImage;
    [SerializeField] float delayText = 0.1f;
    [TextArea][SerializeField] string[] sentences;
    bool isWriting;
    int countText;

    void Start()
    {
        StartCoroutine(WriteText(sentences[countText]));
    }

    IEnumerator WriteText(string sentence)
    {
        isWriting = true;
        arrowImage.SetActive(!isWriting);
        texto.text = "";

        foreach (char letra in sentence)
        {
            texto.text = texto.text + letra;
            yield return new WaitForSeconds(delayText);
        }
        PrepareNextText();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            CheckTexts();
        }
    }

    void CheckTexts()
    {
        if (isWriting)
        {
            StopAllCoroutines();
            texto.text = sentences[countText];
            PrepareNextText();
            return;
        }

        if(countText < sentences.Length)
        {
            StartCoroutine(WriteText(sentences[countText]));
        }
    }
    void PrepareNextText()
    {
        isWriting = false;
        arrowImage.SetActive(!isWriting);
        countText++;
    }
}
