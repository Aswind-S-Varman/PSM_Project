using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingTrigger : MonoBehaviour
{
    public Canvas ExitPrompt;
    public GameObject Weapon;
    public GameObject PauseMenu;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            FindObjectOfType<PlayerMovement>().DisableMovement();
            Weapon.SetActive(false);
            PauseMenu.SetActive(false);
            Debug.Log("Exit Game Screen");
            ExitPrompt.enabled = true;
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Debug.Log("NextLevel");
        Time.timeScale = 1f;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        Debug.Log("Restart");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Qame");
        Application.Quit();
    }

}
