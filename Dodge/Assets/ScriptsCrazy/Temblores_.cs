using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temblores_ : MonoBehaviour
{
    [SerializeField] Text texto;
    [SerializeField] Text_Write writer;
    [SerializeField] Shake_Object shaker;
    [SerializeField] GameObject secondText;
    [SerializeField] GameObject arrowText;
    [SerializeField] GameObject enemies;
    [SerializeField] AudioSource caveShake;

    [SerializeField] bool canDo = true;
    [SerializeField] bool changeText = true;

    void Update()
    {
        if (canDo == false)
        {
            return;
        }

        if (writer.countText >= writer.sentences.Length)
        {
            arrowText.SetActive(false);
            StartCoroutine(ShakeCutscene());
            canDo = false;
        }
    }

    IEnumerator ShakeCutscene()
    {
        yield return new WaitForSeconds(0.5f);
        ShakeCave();
        if (changeText == true)
        {
            yield return new WaitForSeconds(1f);
            texto.text = "!";
            changeText = false;
        }
        yield return new WaitForSeconds(1f);
        ShakeCave();
        yield return new WaitForSeconds(0.5f);
        enemies.SetActive(true);
        secondText.SetActive(true);
        StartCoroutine(ShakeCutscene());
    }

    void ShakeCave()
    {
        shaker.StartShake();
        caveShake.Play();
    }

}