using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public void EasyLevel()
    {
        Debug.Log("Easy Level");
        SceneManager.LoadScene("FirstLevel");
    }
    public void MediumLevel()
    {
        Debug.Log("Medium Level");
        SceneManager.LoadScene("SecondLevel");
    }
    public void HardLevel()
    {
        Debug.Log("Hard Level");
        SceneManager.LoadScene("ThirdLevel");
    }
}
