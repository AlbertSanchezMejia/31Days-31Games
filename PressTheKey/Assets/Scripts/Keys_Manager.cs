using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys_Manager : MonoBehaviour
{
    [SerializeField] Text texto;
    [SerializeField] string[] letters;
    [SerializeField] KeyCode[] keys;
    int number;

    void Start()
    {
        SetArrow();
    }

    void Update()
    {
        if (Input.GetKeyDown(keys[number]))
        {
            texto.text = " ";
            Invoke(nameof(SetArrow), 0.1f);
        }
    }

    void SetArrow()
    {
        number = Random.Range(0, letters.Length);
        texto.text = letters[number];
    }

}
