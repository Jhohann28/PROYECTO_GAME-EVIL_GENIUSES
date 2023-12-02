using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    private bool collected = false; // Variable para verificar si el objeto ha sido recolectado
    
    public void Interact()
    {
        // Verifica si el objeto ya ha sido recolectado
        if (!collected)
        {
            collected = true; // Marca el objeto como recolectado
            
        }
        
    }

    // Método para verificar si el objeto ha sido recolectado
    public bool IsCollected()
    {
        return collected;
    }
}



//private PlayerHun playerHungerScript; // Referencia al script del jugador

//void Start()
//{
//    // Busca el componente PlayerHun en el objeto del jugador
//    playerHungerScript = FindObjectOfType<PlayerHun>();
//}

//// Método para interactuar con el objeto
//public void Interact()
//{
//    // Aumenta el valor de agua en el script del jugador cuando interactúas con este objeto
//    if (playerHungerScript != null)
//    {
//        playerHungerScript.hunger += 20; // Aumenta el agua en 20 unidades (puedes ajustar este valor)
//        playerHungerScript.hunger = Mathf.Clamp(playerHungerScript.hunger, 0, 100); // Asegura que esté dentro del rango

//    }
//}

