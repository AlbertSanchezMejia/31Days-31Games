using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake_Object : MonoBehaviour
{
    [SerializeField] Transform objectToShake;
    [SerializeField] float shakeTime;
    [SerializeField] float shakeDistance = 0.25f;
    Vector3 startPosition;
    bool canShake;

    void Start()
    {
        startPosition = objectToShake.localPosition;
        canShake = false;
    }

    void Update()
    {
        if (canShake)
        {
            objectToShake.localPosition = startPosition + Random.insideUnitSphere * shakeDistance;
        }
    }

    void ShakeTheObject()
    {
        Invoke(nameof(ObjectBackToNormal), shakeTime);
    }

    void ObjectBackToNormal()
    {
        canShake = false;
        objectToShake.localPosition = startPosition;
    }

    public void StartShake()
    {
        CancelInvoke();
        canShake = true;
        ShakeTheObject();
    }

}
