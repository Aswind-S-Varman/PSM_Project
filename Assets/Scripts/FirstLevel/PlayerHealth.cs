using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDeath;

    [SerializeField] float maxHealth = 10f, currentHealth = 0f;

    public GameObject healthbarUI;
    public Slider slider;

    //float damagePlayer = 3f;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        slider.value = CalculateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateHealth();

    }

    public void TakeDamage(float damage)
    {
        Debug.Log("Taken damage");
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            FindObjectOfType<PlayerMovement>().DisableMovement();
            Debug.Log("YOU DIED");
            OnPlayerDeath?.Invoke();
            // Game over. Reset game.
        }
    }

    float CalculateHealth()
    {
        return currentHealth / maxHealth;
    }
}
