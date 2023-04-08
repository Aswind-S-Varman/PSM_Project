using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public void EasyLevel()
    {
        SceneManager.LoadScene("EasyLevel");
    }
    public void MediumLevel()
    {
        SceneManager.LoadScene("MediumLevel");
    }
    public void HardLevel()
    {
        SceneManager.LoadScene("HardLevel");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
