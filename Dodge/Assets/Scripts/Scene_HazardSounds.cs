using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_HazardSounds : MonoBehaviour
{
    [SerializeField] AudioSource stalactites1;
    [SerializeField] AudioSource stalactites2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            if(stalactites1.isPlaying == false)
            {
                stalactites1.Play();
            }
            else
            {
                stalactites2.Play();
            }
        }
    }

}
