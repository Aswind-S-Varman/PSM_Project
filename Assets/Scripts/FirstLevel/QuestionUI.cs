using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionUI : MonoBehaviour
{
    public Text questionText;
    public Button[] answerButtons;
    public GameObject questionPanel;
    public GameObject correctPanel;
    public GameObject incorrectPanel;

    private string correctAnswer;

    public void DisplayQuestion(string question, string[] answers, string correct)
    {
        questionText.text = question;
        correctAnswer = correct;
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponentInChildren<Text>().text = answers[i];
        }
        questionPanel.SetActive(true);
    }

    public void CheckAnswer(string selectedAnswer)
    {
        if (selectedAnswer == correctAnswer)
        {
            questionPanel.SetActive(false);
            correctPanel.SetActive(true);
            FindObjectOfType<PlayerMovement>().EnableMovement();
        }
        else
        {
            questionPanel.SetActive(false);
            incorrectPanel.SetActive(true);
        }
    }
}
