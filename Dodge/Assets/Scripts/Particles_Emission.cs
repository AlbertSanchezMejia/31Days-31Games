using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles_Emission : MonoBehaviour
{
    [SerializeField] ParticleSystem particlesLeft;
    ParticleSystem.EmissionModule emissionLeft;

    [SerializeField] ParticleSystem particlesRight;
    ParticleSystem.EmissionModule emissionRight;

    void Start()
    {
        emissionLeft = particlesLeft.emission;
        emissionRight = particlesRight.emission;
    }

    void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");

        emissionLeft.rateOverTime = (xMov == -1) ? 35 : 0;
        emissionRight.rateOverTime = (xMov == 1) ? 35 : 0;
    }

}
