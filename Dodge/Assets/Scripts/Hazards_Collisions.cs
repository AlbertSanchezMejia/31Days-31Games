using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards_Collisions : MonoBehaviour
{
    [SerializeField] float destroyTime;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject, destroyTime);
        }
    }

}
