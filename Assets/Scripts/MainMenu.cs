using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("EasyLevel");
    }

    public void ChooseLevels()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void QuitQame()
    {
        Application.Quit();
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

}
