using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Particles : MonoBehaviour
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
        float movementDirection = Input.GetAxisRaw("Horizontal");
        EmitMovementParticles(movementDirection);
    }

    void EmitMovementParticles(float direction)
    {
        emissionLeft.rateOverTime = (direction == -1) ? 35 : 0;
        emissionRight.rateOverTime = (direction == 1) ? 35 : 0;
    }

}
