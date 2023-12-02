using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float sensitivity = 2.0f; // Sensibilidad del movimiento de la cámara
    public float maxYAngle = 80.0f; // Máximo ángulo de rotación en el eje Y

    private Vector2 currentRotation = Vector2.zero;

    void Update()
    {
        // Obtener la entrada del mouse para el movimiento de la cámara
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;

        // Restringir el ángulo de rotación vertical
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);

        // Aplicar rotación a la cámara
        transform.localRotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);
    }
}

