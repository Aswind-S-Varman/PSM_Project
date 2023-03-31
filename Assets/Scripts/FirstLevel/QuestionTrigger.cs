using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionTrigger : MonoBehaviour
{
    // Display 'Press E to interact' screen
    public Canvas QuestionPrompt;

    // Reference to PuzzleTrigger script
    public PuzzleTrigger PuzzleScript;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && PuzzleScript.AnswerEntered == false)
        {
            Debug.Log("Entered Question Area");
            QuestionPrompt.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")  && PuzzleScript.AnswerEntered == false)
        {
            Debug.Log("Left Question Area");
            QuestionPrompt.enabled = false;
        }


    }
}
