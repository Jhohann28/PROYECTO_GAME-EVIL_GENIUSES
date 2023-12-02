using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float sensitivity = 2.0f; // Sensibilidad del movimiento de la c�mara
    public float maxYAngle = 80.0f; // M�ximo �ngulo de rotaci�n en el eje Y

    private Vector2 currentRotation = Vector2.zero;

    void Update()
    {
        // Obtener la entrada del mouse para el movimiento de la c�mara
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;

        // Restringir el �ngulo de rotaci�n vertical
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);

        // Aplicar rotaci�n a la c�mara
        transform.localRotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);
    }
}

