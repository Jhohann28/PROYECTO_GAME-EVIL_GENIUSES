using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHun : MonoBehaviour
{
    public float life = 100;
    public float hunger = 100;
    public float water = 100;

    public Image lifeVar;
    public Image lifeHunger;
    public Image lifeWater;

    private float hungerTimer = 0f;
    private float waterTimer = 0f;
    private float decreaseRate = 5f; // Valor para reducir hambre y agua

    void Update()
    {
        // Actualiza las barras de vida, hambre y agua
        UpdateUI();

        // Reduzca el hambre cada 15 segundos
        hungerTimer += Time.deltaTime;
        if (hungerTimer >= 15f)
        {
            DecreaseHunger();
            hungerTimer = 0f; // Reinicia el temporizador de hambre
        }

        // Reduzca el agua cada segundo
        waterTimer += Time.deltaTime;
        if (waterTimer >= 1f)
        {
            DecreaseWater();
            waterTimer = 0f; // Reinicia el temporizador de agua
        }

        // Verifica si la vida ha llegado a cero y desactiva el jugador
        if (life <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    void DecreaseHunger()
    {
        // Reduzca el hambre de 5 en 5
        hunger -= decreaseRate;

        // Si el hambre llega a 0, reduzca la vida de 5 en 5
        if (hunger <= 0)
        {
            DecreaseLife();
        }

        // Asegúrate de que los valores estén dentro del rango permitido
        hunger = Mathf.Clamp(hunger, 0, 100);

        // Actualiza las barras de vida, hambre y agua después de los cambios
        UpdateUI();
    }

    void DecreaseWater()
    {
        // Reduzca el agua de 5 en 5
        water -= decreaseRate;

        // Si el agua llega a 0, reduzca la vida de 5 en 5
        if (water <= 0)
        {
            DecreaseLife();
        }

        // Asegúrate de que los valores estén dentro del rango permitido
        water = Mathf.Clamp(water, 0, 100);

        // Actualiza las barras de vida, hambre y agua después de los cambios
        UpdateUI();
    }

    void DecreaseLife()
    {
        // Reduzca la vida de 5 en 5
        life -= decreaseRate;

        // Asegúrate de que los valores estén dentro del rango permitido
        life = Mathf.Clamp(life, 0, 100);

        // También podrías agregar otras acciones aquí, como reproducir un sonido o mostrar un mensaje

        // Actualiza las barras de vida, hambre y agua después de los cambios
        UpdateUI();
    }

    void UpdateUI()
    {
        // Actualiza las barras de vida, hambre y agua
        lifeVar.fillAmount = life / 100;
        lifeHunger.fillAmount = hunger / 100;
        lifeWater.fillAmount = water / 100;
    }
}
