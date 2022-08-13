using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_ : MonoBehaviour
{
    [SerializeField] float delaySpawn;
    [SerializeField] float delayPlayer;
    [SerializeField] float spaceSpawn;
    [SerializeField] Rigidbody2D prefab;
    Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        Invoke(nameof(SpawnObjects), delaySpawn);
        Invoke(nameof(SpawnToPlayer), delayPlayer);
    }

    void SpawnObjects()
    {
        Instantiatee(Random.Range(-spaceSpawn, spaceSpawn));
        Invoke(nameof(SpawnObjects), delaySpawn);
    }

    void SpawnToPlayer()
    {
        Instantiatee(target.position.x);
        Invoke(nameof(SpawnToPlayer), delayPlayer);
    }

    void Instantiatee(float xPos)
    {
        Rigidbody2D knifeInstance;
        knifeInstance = Instantiate(prefab, new Vector2(xPos, transform.position.y), transform.rotation);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
}
