using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour
{
    public float creditsDuration = 41f; // Duration of the credits sequence

    private void Start()
    {
        // Start a coroutine to wait for the credits to finish
        StartCoroutine(LoadMainMenu());
    }

    IEnumerator LoadMainMenu()
    {
        yield return new WaitForSeconds(creditsDuration);

        // Load the main menu scene
        SceneManager.LoadScene("StartMenu");
    }
}
