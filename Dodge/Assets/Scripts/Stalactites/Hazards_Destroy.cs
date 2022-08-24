using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.ParticleSystem;

public class Hazards_Destroy : MonoBehaviour
{
    [SerializeField] float destroyTime;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

}
