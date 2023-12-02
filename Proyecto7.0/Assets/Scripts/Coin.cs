using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IlL
{
    private int amount;

    private void Awake()
    {
        amount = Random.Range(1, 3);
    }
    public void Interact(Player player)
    {
        player.AddCoins(amount);
        Destroy(this.gameObject);
    }
}
