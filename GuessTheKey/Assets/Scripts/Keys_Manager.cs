using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys_Manager : MonoBehaviour
{
    [SerializeField] Text texto;
    [SerializeField] Image imagen;
    [SerializeField] Color greenColor;

    [SerializeField] KeyCode[] keys;
    KeyCode choosenKey;

    [SerializeField] Camera_ScreenShake shake1;
    [SerializeField] Camera_ScreenShake shake2;
    [SerializeField] Camera_ScreenShake shake3;

    [SerializeField] AudioSource ohNo;
    [SerializeField] AudioSource goodTo;


    void Start()
    {
        SetChoosenKey();
    }

    void Update()
    {
        if(goodTo.isPlaying == false)
        {
            GetKeysDown();
        }
    }

    void SetChoosenKey()
    {
        int a = Random.Range(0, keys.Length);
        choosenKey = keys[a];
    }

    void GetKeysDown()
    {
        foreach (KeyCode item in keys)
        {
            if (Input.GetKeyDown(item))
            {
                CheckPressedKey(item);
            }
        }
    }

    void CheckPressedKey(KeyCode pressedKey)
    {
        if(pressedKey == choosenKey)
        {
            Invoke(nameof(StartScreenShake), 3.25f);
            ohNo.Stop();
            goodTo.Play();
            shake3.EmpezarSacudirPantalla();        
        }
        else
        {
            texto.fontSize = 45;
            goodTo.Stop();
            shake2.EmpezarSacudirPantalla();
            ohNo.Play();
            texto.text = "No estaba pensando la tecla     '" + pressedKey + "' vuelve a intentarlo";
            ChangeUIsColor(Color.red);
        }
    }

    void ChangeUIsColor(Color newColor)
    {
        imagen.color = newColor;
        texto.color = newColor;
    }

    void StartScreenShake()
    {
            texto.fontSize = 90;
            texto.text = "¡" + choosenKey + "! ¡¡YESSS!!";
            ChangeUIsColor(greenColor);
        shake1.EmpezarSacudirPantalla();
    }
}
