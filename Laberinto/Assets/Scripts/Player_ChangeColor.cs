using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ChangeColor : MonoBehaviour
{
    [SerializeField] Material winnerColor;
    [SerializeField] GameObject winImage;
    [SerializeField] GameObject winLose;
    [SerializeField] AudioSource sfx;
    MeshRenderer mesh;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Changer"))
        {
            CheckMaterialsColors(other.gameObject.GetComponent<Changer_>());
        }
    }

    void CheckMaterialsColors(Changer_ changer)
    {
        if (mesh.material.color == changer.wantedMaterial.color)
        {
            sfx.Play();
            mesh.material = changer.mesh.material;
            changer.ChangeColor();
        }
        CheckColor();
    }

    void CheckColor()
    {
        if(mesh.material.color == winnerColor.color)
        {
            winLose.SetActive(false);
            winImage.SetActive(true);
        }
    }

}
