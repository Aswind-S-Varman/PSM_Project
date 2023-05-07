using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthGain : MonoBehaviour
{
    float healPlayer = 3f;

    public AudioSource audioSource;
    public AudioClip hitSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Check if the collision is with the player
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(hitSound, transform.position);

            Debug.Log("HEAL");
            // Increase the health of the player
            other.gameObject.GetComponent<PlayerHealth>().Heal(healPlayer);

            // Destroy the medicine gameobject
            Destroy(gameObject);
        }
    }
}
