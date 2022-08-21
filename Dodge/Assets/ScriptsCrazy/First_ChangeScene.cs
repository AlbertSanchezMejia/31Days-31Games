using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_ChangeScene : MonoBehaviour
{
    [SerializeField] Text_Write writer;
    [SerializeField] Scene_Change changer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (writer.countText >= writer.sentences.Length)
            {
                changer.StartCoro();
                gameObject.SetActive(false);
            }
        }

    }

}
