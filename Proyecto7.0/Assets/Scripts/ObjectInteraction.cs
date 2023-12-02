using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectInteraction : MonoBehaviour
{
    public GameObject objectPrefab; // Objeto real que se colocará
    public GameObject previewObject; // Objeto de vista previa
    private GameObject spawnedObject; // Objeto que se crea y coloca en escena
    private bool isPreviewShown = false; // Estado de si se está mostrando la vista previa
    void Update()
    {
        HandleObjectInteraction();
    }
    void HandleObjectInteraction()
    {
        // Si se hace clic o toca la pantalla
        if (Input.GetMouseButtonDown(0))
        {
            if (isPreviewShown)
            {
                PlaceObject();
            }
            else
            {
                ShowPreview();
            }
        }
    }
    void ShowPreview()
    {
        // Mostrar la vista previa y desactivar el objeto real
        previewObject.SetActive(true);
        objectPrefab.SetActive(false);
        isPreviewShown = true;
    }
    void PlaceObject()
    {
        // Colocar el objeto real en la posición de la vista previa
        spawnedObject = Instantiate(objectPrefab, previewObject.transform.position, previewObject.transform.rotation);
        spawnedObject.SetActive(true);
        // Ocultar la vista previa y desactivar el objeto de vista previa
        previewObject.SetActive(false);
        objectPrefab.SetActive(false);
        isPreviewShown = false;
    }
}