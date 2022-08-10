using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_ScreenShake : MonoBehaviour
{
    [SerializeField] Transform camara;
    [SerializeField] float tiempoSacudir;

    float duracionSacudir = 0f;
    [SerializeField] float fuerzaSacudir = 0.25f;

    Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = camara.localPosition;
    }

    void Update()
    {
        if (duracionSacudir > 0 && Time.timeScale != 0) SacudirLaPantalla();
        else CamaraEstadoNormal();
    }

    void SacudirLaPantalla()
    {
        camara.localPosition = posicionInicial + Random.insideUnitSphere * fuerzaSacudir;
        duracionSacudir -= Time.deltaTime;
    }

    void CamaraEstadoNormal()
    {
        duracionSacudir = 0f;
        camara.localPosition = posicionInicial;
    }

    public void EmpezarSacudirPantalla()
    {
        duracionSacudir = tiempoSacudir;
    }

}
