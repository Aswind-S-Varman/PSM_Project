using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float startHealth = 10f, currentHealth = 0f;

    public GameObject healthbarUI;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startHealth;
        slider.value = CalculateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateHealth();

        if (currentHealth <= 0)
        {
            //Destroy(gameObject, 1f);
            gameObject.SetActive(false);
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }

    float CalculateHealth()
    {
        return currentHealth / startHealth;
    }
}
