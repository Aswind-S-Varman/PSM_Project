using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausedMenuUI;

    public GameObject Weapon;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pausedMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

        FindObjectOfType<PlayerMovement>().EnableMovement();

        Weapon.SetActive(true);

    }

    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        pausedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        FindObjectOfType<PlayerMovement>().DisableMovement();
        Weapon.SetActive(false);
    }

    public void LoadMenu()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        //SceneManager.LoadScene("Menu");
        Debug.Log("Loading Menu");

        Weapon.SetActive(false);

    }

    public void QuitGame()
    {
        Debug.Log("Quit Qame");
        Application.Quit();
    }

}
