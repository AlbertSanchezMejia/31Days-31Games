using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Luz_Temblores : MonoBehaviour
{
    [SerializeField] Text texto;
    [SerializeField] Shake_Object shaker;
    [SerializeField] Animator animator;
    [SerializeField] bool canStart;
    [SerializeField] GameObject finalText;
    [SerializeField] Image whiteScreen;
    [SerializeField] Color transparentWhite;
    [SerializeField] AudioSource caveShake;
    [SerializeField] AudioSource caveLight;
    [SerializeField] AudioSource caveAmbiental;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if(canStart == false) { return; }

            canStart = false;
            StartCoroutine(FinalCutscene());
        }
    }

    IEnumerator FinalCutscene()
    {
        shaker.StartShake();
        caveShake.Play();

        yield return new WaitForSeconds(1f);
        texto.text = "!";

        yield return new WaitForSeconds(1f);
        shaker.shakeDistance = 0.4f;
        shaker.StartShake();
        caveShake.Play();

        yield return new WaitForSeconds(1f);
        texto.text = "¿Otro Derrumbe?";

        yield return new WaitForSeconds(0.5f);
        shaker.shakeTime = 1.8f;
        shaker.shakeDistance = 0.6f;
        shaker.StartShake();
        caveAmbiental.Stop();
        caveLight.Play();
        animator.Play("theLight");

        yield return new WaitForSeconds(0.5f);
        whiteScreen.color = transparentWhite;

        yield return new WaitForSeconds(1f);
        shaker.shakeDistance = 0.25f;

        yield return new WaitForSeconds(0.6f);
        finalText.SetActive(true);
    }



}
