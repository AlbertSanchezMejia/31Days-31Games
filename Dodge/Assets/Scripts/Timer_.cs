using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_ : MonoBehaviour
{
    [SerializeField] float Timer;
    [SerializeField] GameObject[] stalactites;
    float staCount;

    [SerializeField] Scene_Change changer;

    void Start()
    {
        staCount = Timer - 5f;
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        int a = 0;
        while (Timer >= 0f)
        {
            Timer -= Time.deltaTime;
            if(staCount >= Timer)
            {
                staCount -= 5;
                stalactites[a].SetActive(false);
                a++;
            }
            yield return null;
        }
        yield return new WaitForSeconds(2f);
        changer.StartBlack();
    }
}
