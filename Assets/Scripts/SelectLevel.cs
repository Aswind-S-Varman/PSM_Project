using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public void EasyLevel()
    {
        SceneManager.LoadScene("FirstLevel");
    }
    public void MediumLevel()
    {
        SceneManager.LoadScene("SecondLevel");
    }
    public void HardLevel()
    {
        SceneManager.LoadScene("ThirdLevel");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
