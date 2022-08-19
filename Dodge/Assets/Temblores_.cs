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

    [SerializeField] bool canDo = true;
    [SerializeField] bool changeText = true;
    [SerializeField] bool startShake = false;

    void Update()
    {
        if (canDo == false)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (writer.countText >= writer.sentences.Length && startShake)
            {
                arrowText.SetActive(false);
                StartCoroutine(ShakeCutscene());
                canDo = false;
            }
            else
            {
                startShake = true;
            }
        }
    }
    IEnumerator ShakeCutscene()
    {
        shaker.StartShake();
        if(changeText == true)
        {
            yield return new WaitForSeconds(1f);
            texto.text = "!";
            changeText = false;
        }
        yield return new WaitForSeconds(1f);
        shaker.StartShake();
        yield return new WaitForSeconds(0.25f);
        enemies.SetActive(true);
        yield return new WaitForSeconds(1f);
        secondText.SetActive(true);
        StartCoroutine(ShakeCutscene());

    }
}