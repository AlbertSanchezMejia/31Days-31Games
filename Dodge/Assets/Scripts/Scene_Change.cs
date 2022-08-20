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
    [SerializeField] Text_Write writer;

    [Header("BlackScreen")]
    //[SerializeField] float delayTime;
    [SerializeField] Image blackScreen;
    [SerializeField] float[] alphavalues;
    Color theColor;

    void Start()
    {
        theColor = blackScreen.color;
        StartCoroutine(CoWhiteScreen());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && SceneManager.GetActiveScene().buildIndex == 1)
        {
            StartCoro();
        }

    }
    public void StartCoro()
    {
        writer.StopAllCoroutines();
        writer.enabled = false;
        StopAllCoroutines();
        StartBlack();
    }

    public void StartBlack()
    {
        StartCoroutine(CoBlackScreen());
    }

    IEnumerator CoBlackScreen()
    {
        int a = 0;
        theColor.a = alphavalues[a];
        while (theColor.a != 1)
        {
            theColor.a = alphavalues[a];
            blackScreen.color = theColor;
            a++;
            yield return new WaitForSeconds(0.1f);
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
        theColor.a = alphavalues[i];
        while (theColor.a != alphavalues[0])
        {
            theColor.a = alphavalues[i];
            blackScreen.color = theColor;
            i--;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(0.1f);
        theColor.a = 0;
        blackScreen.color = theColor;
    }
}
