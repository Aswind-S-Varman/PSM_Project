using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingCoins : MonoBehaviour
{

    // Sounds
    public AudioSource coin;

    public void OnTriggerEnter(Collider other)
    {
        PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();

       if (playerMovement != null)
        {
            coin.Play();
            playerMovement.CoinsCollected();
            Debug.Log("Coin Collected");
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
}
