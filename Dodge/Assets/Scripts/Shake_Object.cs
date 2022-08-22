using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake_Object : MonoBehaviour
{
    [SerializeField] Transform objectToShake;
    public float shakeTime;
    public float shakeDistance = 0.25f;
    Vector3 startPosition;
    public bool canShake;

    void Start()
    {
        startPosition = objectToShake.localPosition;
        if (canShake)
        {
            ShakeTheObject();
        }
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

    public void ObjectBackToNormal()
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
