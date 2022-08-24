using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_HazardSounds : MonoBehaviour
{
    [SerializeField] AudioSource sfxStalactites1;
    [SerializeField] AudioSource sfxStalactites2;
    bool shouldPlay1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Stalactites"))
        {
            PlayStalactiteSfx();
        }
    }

    void PlayStalactiteSfx()
    {
        if (shouldPlay1 == true)
        {
            sfxStalactites1.Play();
        }
        else
        {
            sfxStalactites2.Play();
        }

        shouldPlay1 = !shouldPlay1;
    }

}
