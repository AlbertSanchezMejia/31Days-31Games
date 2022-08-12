using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key_Desactivate : MonoBehaviour
{
    [SerializeField] Keys_List list;
    public KeyCode myKey;
    public bool canDesactivate;
    public Text myText;

    void Awake()
    {
        myText = transform.GetChild(0).GetComponent<Text>();
        canDesactivate = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(myKey) && canDesactivate && Time.timeScale == 1)
        {
            Desactivate();
        }
    }

    void Desactivate()
    {
        list.NextObject();
        gameObject.SetActive(false);

    }

}
