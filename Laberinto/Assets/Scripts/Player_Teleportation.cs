using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Teleportation : MonoBehaviour
{
    bool isTeleporting;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Teleporter"))
        {
            if(isTeleporting)
            {
                isTeleporting = false;
                return;
            }
            transform.position = other.gameObject.GetComponent<Teleporter_>().destination.position;
            isTeleporting = true;
        }
    }


}
