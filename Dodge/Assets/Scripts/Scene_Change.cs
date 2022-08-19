using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_Change : MonoBehaviour
{
    [Header("Change Scene")]
    [SerializeField] int sceneNumber;
    [SerializeField] bool canChange;

    [Header("BlackScreen")]
    [SerializeField] float delayTime;
    [SerializeField] Image blackScreen;
    [SerializeField] float[] alphavalues;
    Color theColor;

    void Start()
    {
        theColor = blackScreen.color;
        StartCoroutine(CoWhiteScreen());
    }

    IEnumerator CoBlackScreen()
    {
        int a = 0;
        while (blackScreen.color.a != 1)
        {
            theColor.a = alphavalues[a];
            blackScreen.color = theColor;
            a++;
            yield return new WaitForSeconds(delayTime);
        }

        ChangeScene();
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }

    IEnumerator CoWhiteScreen()
    {
        int i = alphavalues.Length - 1;
        while (blackScreen.color.a <= 0)
        {
            theColor.a = alphavalues[i];
            blackScreen.color = theColor;
            i--;
            yield return new WaitForSeconds(1f);
        }
        yield return new WaitForSeconds(0.25f);
        theColor.a = 0;
        blackScreen.color = theColor;
    }
}
