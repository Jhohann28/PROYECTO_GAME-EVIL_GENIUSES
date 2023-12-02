using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealht : MonoBehaviour
{

    public float life = 100;

    public Image lifeVar;
   
    void Update()
    {
        life = Mathf.Clamp(life, 0, 100);

        lifeVar.fillAmount = life / 100;
    }
}
