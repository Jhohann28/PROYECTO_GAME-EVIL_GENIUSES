using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5.0f;
    private Rigidbody rb;
    void Start()
    {
        // Obt�n el componente Rigidbody de la c�psula
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // Obt�n la entrada del jugador (por ejemplo, teclas W, A, S, D o flechas)
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        // Calcula el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
        // Aplica el movimiento al objeto usando el Rigidbody
        rb.velocity = movimiento * velocidad;
    }

}
