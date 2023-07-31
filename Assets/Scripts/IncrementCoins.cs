using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class IncrementCoins : MonoBehaviour
{
    int coins;
    private void Start()
    {
        coins = 0;
    }

    public TextMeshProUGUI coinCounter;
    public void IncrementCounter()
    {
       coinCounter.text="Number of Coins Collected: "+ (++coins).ToString();
    }
}
