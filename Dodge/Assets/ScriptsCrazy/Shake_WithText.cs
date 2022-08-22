using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Shake_WithText : MonoBehaviour
{
    [SerializeField] Text_Write writer;
    [SerializeField] Shake_Object shaker;
    [SerializeField] int textCount;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (writer.countText == textCount)
            {
                shaker.canShake = true;
                return;
            }
            if (writer.countText >= textCount)
            {
                shaker.ObjectBackToNormal();
                gameObject.SetActive(false);
            }
        }
    }

}
