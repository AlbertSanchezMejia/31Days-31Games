using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys_List : MonoBehaviour
{
    [SerializeField] GameObject timer;
    [SerializeField] Key_Desactivate[] objects;
    [SerializeField] KeyCode[] keys;
    [SerializeField] string[] arrows;
    int counter = 0;

    void Start()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            int a = Random.Range(0, keys.Length);
            objects[i].myKey = keys[a];
            objects[i].myText.text = arrows[a];
        }

        canActivate();
    }

    public void NextObject()
    {
        if (counter + 1 >= objects.Length)
        {
            Debug.Log("Ganaste");
            timer.SetActive(false);
            return;
        }
        counter++;
        Invoke(nameof(canActivate), 0.1f);
    }

    void canActivate()
    {
        objects[counter].canDesactivate = true;
    }

}
