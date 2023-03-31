using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyController : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject projectilePrefab;
    public float lookAtDistance = 10f;
    public float shootInterval = 2f;

    private bool canShoot = true;
    public static event Action OnPlayerDeath;


    private void Update()
    {
        // Make the enemy look at the player if the player is within a certain distance
        if (Vector3.Distance(transform.position, playerTransform.position) < lookAtDistance)
        {
            transform.LookAt(playerTransform);
        }

        // Shoot projectiles at a certain interval
        if (canShoot && Vector3.Distance(transform.position, playerTransform.position) < lookAtDistance)
        {
            StartCoroutine(Shoot());
        }
    }

    private IEnumerator Shoot()
    {
        // Instantiate a new projectile at the enemy's position and rotation
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);

        // Disable shooting for a short period to prevent spamming
        canShoot = false;
        yield return new WaitForSeconds(shootInterval);
        canShoot = true;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, shootInterval);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, lookAtDistance);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<PlayerMovement>().DisableMovement();
            Debug.Log("YOU DIED");
            OnPlayerDeath?.Invoke();
        }
    }
}
