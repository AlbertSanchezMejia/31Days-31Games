using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards_Collisions : MonoBehaviour
{
    [SerializeField] float destroyTime;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

}
