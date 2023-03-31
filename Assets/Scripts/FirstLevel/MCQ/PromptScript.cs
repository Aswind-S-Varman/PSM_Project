using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptScript : MonoBehaviour
{
    // Display 'Press E to interact' screen
    public Canvas QuestionPrompt;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entered Question Area");
            QuestionPrompt.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Left Question Area");
            QuestionPrompt.enabled = false;
        }


    }
}
