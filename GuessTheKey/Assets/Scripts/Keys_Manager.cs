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

    void Start()
    {
        SetChoosenKey();
    }

    void Update()
    {
        GetKeysDown();
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
            texto.text = "¡Así es! Estaba pensando           en la tecla: '" + pressedKey + "'";
            ChangeUIsColor(greenColor);
        }
        else
        {
            texto.text = "No estaba pensando la tecla '" + pressedKey + "' vuelve a intentarlo";
            ChangeUIsColor(Color.red);
        }
    }

    void ChangeUIsColor(Color newColor)
    {
        imagen.color = newColor;
        texto.color = newColor;
    }

}
