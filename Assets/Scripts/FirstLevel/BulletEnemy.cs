using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public float life = 5;
    float damagePlayer = 3f;
    //public GameObject explosionEffect; // particle effect to play when bullet hits the enemy bullet


    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reduce the health of the player
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damagePlayer);

            // Destroy the bullet gameobject
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Bullet")) // check if collided object is the enemy bullet
        {
            Destroy(collision.gameObject); // destroy the enemy bullet
            Debug.Log("Destroyed VIRUS BULLET");
            //Instantiate(explosionEffect, collision.transform.position, Quaternion.identity); // create particle effect at the enemy bullet's position
            Destroy(gameObject); // destroy the player bullet
        }
    }

}
