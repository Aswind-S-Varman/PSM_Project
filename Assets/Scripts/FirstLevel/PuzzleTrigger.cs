using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PuzzleTrigger : MonoBehaviour
{
    // Canvas'
    public Canvas QuestionPrompt;
    public Canvas Puzzle_Canvas;

    // Text
    public TMP_InputField UserInputText;
    public string Answer = "Covid-19";
    
    // Answer not entered
    public bool AnswerEntered = false;

    public GameObject questionBox;

    public void Update()
    {
        if (UserInputText.text == Answer && AnswerEntered == false)
        {
            // movement 
            Debug.Log("The answer is correct !");
            AnswerEntered = true;
            Puzzle_Canvas.enabled = false;
            QuestionPrompt.enabled = false;
            FindObjectOfType<PlayerMovement>().EnableMovement();
            Cursor.lockState = CursorLockMode.Locked;
            Destroy(questionBox);

            Debug.Log("The score is added !");
            ScoringSystem.score += 10;
        }
    }

    void OnTriggerStay (Collider other)
    {
        if (other.CompareTag("Player") && AnswerEntered == false)
        {
            // Check keypress E
            if (Input.GetKey(KeyCode.E))
            {
                // Show Puzzle Canvas
                Puzzle_Canvas.enabled = true;

                // Hide E prompt
                QuestionPrompt.enabled = false;

                // Stop player movement
                FindObjectOfType<PlayerMovement>().DisableMovement();                

                // Give cursor access
                Cursor.lockState = CursorLockMode.None;
            }
            if(Input.GetKey(KeyCode.Escape))
            {
                ExitButton();
            }
        }
    }

    public void ExitButton()
    {
        Puzzle_Canvas.enabled = false;
        QuestionPrompt.enabled = true;
        FindObjectOfType<PlayerMovement>().EnableMovement();

        // Lock Cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

}
