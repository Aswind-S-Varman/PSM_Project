using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public float life = 5;
    float damagePlayer = 3f;
    public AudioSource audioSource;
    public AudioClip hitSound;
    public AudioSource audioSource1;
    public AudioClip contactSound;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource1 = GetComponent<AudioSource>();
    }
    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(contactSound, transform.position);
            Debug.Log("Audio clip name: " + contactSound.name);

            // Reduce the health of the player
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damagePlayer);
             
            // Destroy the bullet gameobject
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Bullet")) // check if collided object is the enemy bullet
        {
            AudioSource.PlayClipAtPoint(hitSound, transform.position);
            Destroy(collision.gameObject); // destroy the enemy bullet
            Debug.Log("Destroyed VIRUS BULLET");
            Destroy(gameObject); // destroy the player bullet
        }
    }

}
