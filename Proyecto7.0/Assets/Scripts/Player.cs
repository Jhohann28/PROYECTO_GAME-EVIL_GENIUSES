using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5.0f;
    public Rigidbody rb;
    private int _coins = 0;
    public void AddCoins(int coins)
    {
        _coins += coins;
    }
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0, movimientoVertical);
       
        rb.velocity = movimiento * velocidad;
    }
    private void OnTriggerEnter(Collider other)
    {
        IlL interactable = other.GetComponent<IlL>();
        if (interactable != null)
        {
            interactable.Interact(this);
        }
    }


}
