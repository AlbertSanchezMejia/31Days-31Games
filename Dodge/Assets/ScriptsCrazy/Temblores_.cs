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

        yield return new WaitForSeconds(1f);
        texto.text = "!";

        yield return new WaitForSeconds(1f);
        ShakeCave();

        yield return new WaitForSeconds(1f);
        enemies.SetActive(true);
        secondText.SetActive(true);

        InvokeRepeating(nameof(ShakeCave), 2.5f, 2.5f);
    }

    void ShakeCave()
    {
        shaker.StartShake();
        caveShake.Play();
    }

}