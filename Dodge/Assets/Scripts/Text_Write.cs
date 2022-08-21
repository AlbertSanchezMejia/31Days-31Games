using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Write : MonoBehaviour
{
    [SerializeField] AudioSource soundText;
    [SerializeField] AudioSource soundSkip;
    [SerializeField] Text texto;
    [SerializeField] GameObject arrowImage;
    [SerializeField] float delayText = 0.1f;
    public string[] sentences;
    public int countText;
    bool isWriting;

    void Start()
    {
        StartCoroutine(WriteText(sentences[countText]));
    }

    IEnumerator WriteText(string sentence)
    {
        soundText.Play();
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

    void LateUpdate()
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
            soundSkip.Play();
            StopAllCoroutines();
            texto.text = sentences[countText];
            PrepareNextText();
        }
        else if(countText < sentences.Length)
        {
            StartCoroutine(WriteText(sentences[countText]));
        }
    }

    void PrepareNextText()
    {
        soundText.Pause();
        isWriting = false;
        arrowImage.SetActive(!isWriting);
        countText++;
    }
}
