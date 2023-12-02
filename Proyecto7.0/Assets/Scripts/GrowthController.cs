using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthController : MonoBehaviour
{
    public GameObject sphereSeed; // GameObject de la esfera
    public GameObject capsuleYoung; // GameObject de la cápsula
    public GameObject cubeYoung; // GameObject del cubo
    private bool isSeed = true; // Inicialmente, la planta está en la etapa de semilla
    private bool showCube = false; // Estado para mostrar el cubo
    private float lastChangeTime; // Registro del tiempo del último cambio

    void Start()
    {
        // Al iniciar, activamos el modelo de semilla y desactivamos el de la planta joven
        sphereSeed.SetActive(true);
        capsuleYoung.SetActive(false);
        cubeYoung.SetActive(false);

        lastChangeTime = Time.time;
    }

    void Update()
    {
        // Cambiar cada 5 segundos si no se ha mostrado el cubo
        if (Time.time - lastChangeTime > 5f && !showCube)
        {
            lastChangeTime = Time.time;

            if (isSeed)
            {
                isSeed = false;
                sphereSeed.SetActive(false);
                capsuleYoung.SetActive(true);
            }
            else
            {
                isSeed = true;
                sphereSeed.SetActive(false);
                capsuleYoung.SetActive(false);
                cubeYoung.SetActive(true);
                if (isSeed)
                {
                    isSeed = false;
                    sphereSeed.SetActive(false);
                    capsuleYoung.SetActive(false);
                    return;
                }
                
                
            }
            
        }
    }

}
