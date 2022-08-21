using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final_Cutscene : MonoBehaviour
{
    [SerializeField] Text_Write writer;
    [SerializeField] AudioSource aCelestial;
    [SerializeField] Animator animator;
    [SerializeField] bool startEnd = true;
    [SerializeField] GameObject elTexto;

    [SerializeField] Animator blackScreen;
    [SerializeField] Animator whiteScreen;
    [SerializeField] Animator otherWhite;
    [SerializeField] GameObject ThanksText;

    void Update()
    {
        if (writer.countText >= writer.sentences.Length)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                if (startEnd == false) { return; }
                startEnd = false;
                StartCoroutine(FinalScene());
            }
        }
    }

    IEnumerator FinalScene()
    {
        elTexto.SetActive(false);
        yield return new WaitForSeconds(1f);
        aCelestial.Play();
        animator.Play("PlayerGoLight");
        yield return new WaitForSeconds(10f);
        blackScreen.Play("BlackAppear");
        whiteScreen.Play("WhiteAppear");
        yield return new WaitForSeconds(3.5f);
        ThanksText.SetActive(true);
        otherWhite.Play("white");

    }

}
