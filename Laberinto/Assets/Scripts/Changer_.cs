using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer_ : MonoBehaviour
{
    public Material wantedMaterial;
    [HideInInspector] public MeshRenderer mesh;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    public void ChangeColor()
    {
        mesh.material = wantedMaterial;
    }

}
