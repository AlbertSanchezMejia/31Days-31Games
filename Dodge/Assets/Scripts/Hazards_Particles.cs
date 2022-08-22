using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Hazards_Particles : MonoBehaviour
{
    [SerializeField] Transform particles;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HazardSound"))
        {
            Instantiate(particles, transform.position, particles.rotation);
        }
    }

}
