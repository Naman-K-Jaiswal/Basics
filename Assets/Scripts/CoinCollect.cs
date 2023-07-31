
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CoinCollect : MonoBehaviour
{
    public IncrementCoins IC;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player collected a coin");
            IC.IncrementCounter();
            Destroy(this.gameObject);
        }
    }
}
