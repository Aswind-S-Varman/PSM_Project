using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionTrigger3 : MonoBehaviour
{
    [SerializeField] GameObject MasterControl;

    public Canvas QuestionPrompt;
    public Canvas MCQ_Canvas;

    private int numQuestions = 5;

    public GameObject questionBox2;

    // Disable answers
    public GameObject AnswerA;
    public GameObject AnswerB;
    public GameObject AnswerC;
    public GameObject AnswerD;

    //Disable gun
    public GameObject Weapon;

    public void Update()
    {
        QuestionAnswered();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Check keypress E
            if (Input.GetKey(KeyCode.E))
            {
                MasterControl.SetActive(true);
                // Show Puzzle Canvas
                MCQ_Canvas.enabled = true;

                // Hide E prompt
                QuestionPrompt.enabled = false;

                // Stop player movement
                FindObjectOfType<PlayerMovement>().DisableMovement();

                // Give cursor access
                Cursor.lockState = CursorLockMode.None;

                // Access and modify the "shouldExecute" flag in the QuestionGenerate script
                QuestionGenerate1.shouldExecute = true;

                // Lock the weapon
                Weapon.SetActive(false);
            }

            if (Input.GetKey(KeyCode.Escape))
            {
                ExitButton();
            }
        }
    }

    public void QuestionAnswered()
    {
        //Find the QuestionGenerateScript
        QuestionGenerate1 questionGenerate = FindObjectOfType<QuestionGenerate1>();

        if(questionGenerate != null)
        {
            //Check if all questions answered
            if (questionGenerate.questionCount >= numQuestions)
            {
               // MasterControl.SetActive(false);
                Debug.Log("The total questions answered is " + questionGenerate.questionCount);
                Debug.Log("The quiz is done !");
                // Access and modify the "shouldExecute" flag in the QuestionGenerate script
                QuestionGenerate1.shouldExecute = false;

                MCQ_Canvas.enabled = false;
                QuestionPrompt.enabled = false;
                FindObjectOfType<PlayerMovement>().EnableMovement();
                Cursor.lockState = CursorLockMode.Locked;
                questionBox2.SetActive(false);

                AnswerA.SetActive(false);
                AnswerB.SetActive(false);
                AnswerC.SetActive(false);
                AnswerD.SetActive(false);

                Weapon.SetActive(true);

            }
        }
    }


    public void ExitButton()
    {
        MasterControl.SetActive(false);

        MCQ_Canvas.enabled = false;
        QuestionPrompt.enabled = true;
        FindObjectOfType<PlayerMovement>().EnableMovement();

        // Lock Cursor
        Cursor.lockState = CursorLockMode.Locked;

        Weapon.SetActive(true);
    }
}
