using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    public GameObject item;
    public int ID;
    public string type;
    public string description;

    public bool empty;
    public Sprite icon;

    public Transform slotIconGameObject;
    public InteractableObject interactableObject;
    private PlayerHun playerHungerScript;
   
    private void Start()
    {
        slotIconGameObject = transform.GetChild(0);
       
        playerHungerScript = FindObjectOfType<PlayerHun>(); // Encuentra el script del jugador
       
    }

    public void UpdateSlot()
    {
        slotIconGameObject.GetComponent<Image>().sprite = icon;
    }

    public void UseItem()
    {
        item.GetComponent<Item>().ItemUsage();

        if (playerHungerScript != null)
        {
            // Aumenta el hambre del jugador
            playerHungerScript.hunger += 20; // Aumenta el hambre en 20 unidades (ajusta según lo necesario)
            playerHungerScript.hunger = Mathf.Clamp(playerHungerScript.hunger, 0, 100); // Asegura que esté dentro del rango
        }
    }

    public void OnPointerClick(PointerEventData pointerEvenData)
    {
        UseItem();

          // Verifica si el objeto ha sido recolectado
        if (interactableObject != null && interactableObject.IsCollected())
        {
            // Llama al método para usar el ítem
            interactableObject.Interact();
        }
    }

}
