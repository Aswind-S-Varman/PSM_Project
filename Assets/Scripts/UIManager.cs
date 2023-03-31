using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject Weapon;
    public GameObject PauseMenu;

    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += EnableGameOverMenu;
        EnemyController.OnPlayerDeath += EnableGameOverMenu;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= EnableGameOverMenu;
    }

    public void EnableGameOverMenu()
    {
        FindObjectOfType<PlayerMovement>().DisableMovement();
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        Weapon.SetActive(false);
        PauseMenu.SetActive(false);

        gameOverMenu.SetActive(true);
        Debug.Log("Game Over screen");
    }

    public void RestartLevel()
    {
        Debug.Log("Restart Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        Debug.Log("Main Menu");
        //SceneManager.LoadScene("MainMenu");
    }
}
