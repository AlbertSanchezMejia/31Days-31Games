using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_ : MonoBehaviour
{
    [SerializeField] float delaySpawn;
    [SerializeField] float spaceSpawn;
    [SerializeField] Rigidbody2D prefab;
    [SerializeField] float gravityValue;
    Vector2 positionSpawn;

    void Start()
    {
        positionSpawn.y = transform.position.y;
        Invoke(nameof(StartSpawn), delaySpawn);
    }

    void StartSpawn()
    {
        SpawnObjects();
        Invoke(nameof(StartSpawn), delaySpawn);
    }

    void SpawnObjects()
    {
        positionSpawn.x = Random.Range(-spaceSpawn, spaceSpawn);
    
        Rigidbody2D knifeInstance;
        knifeInstance = Instantiate(prefab, positionSpawn, transform.rotation);
        knifeInstance.gravityScale = gravityValue;
    }

}
