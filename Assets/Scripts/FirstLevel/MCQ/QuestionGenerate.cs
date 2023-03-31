using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;

    public int questionCount = 0;

    // Set the range of numbers to select from
    public int minNumber = 1;
    public int maxNumber = 5;

    // Create a list to keep track of the numbers that have already been selected
    private List<int> selectedNumbers = new List<int>();

    public static bool shouldExecute = false;

    private void Start()
    {
        shouldExecute = false;
    }

    void Update()
    {
        if(shouldExecute == true)
        {
            if (displayingQuestion == false)
            {
                displayingQuestion = true;

                // Select a random number
                int randomNumber = GetRandomNumber();

                // Do something with the random number
                Debug.Log("Random number selected: " + randomNumber);

                if (randomNumber == 1)
                {
                    QuestionDisplay.newQuestion = "What is the common cold caused by?";
                    QuestionDisplay.newA = "A. Bacteria";
                    QuestionDisplay.newB = "B. Fungi";
                    QuestionDisplay.newC = "C. Viruses";
                    QuestionDisplay.newD = "D. Vaccines";
                    actualAnswer = "C";
                }

                if (randomNumber == 2)
                {
                    QuestionDisplay.newQuestion = "Which of the following is a common symptom of influenza (flu)?";
                    QuestionDisplay.newA = "A. Sore throat";
                    QuestionDisplay.newB = "B. Loss of taste or smell";
                    QuestionDisplay.newC = "C. Skin rash";
                    QuestionDisplay.newD = "D. Coughing";
                    actualAnswer = "A";
                }

                if (randomNumber == 3)
                {
                    QuestionDisplay.newQuestion = "What is NOT a symptom of COVID-19?";
                    QuestionDisplay.newA = "A. Difficulty breathing";
                    QuestionDisplay.newB = "B. Loss of taste or smell";
                    QuestionDisplay.newC = "C. Coughing";
                    QuestionDisplay.newD = "D. Sneezing";
                    actualAnswer = "D";
                }

                if (randomNumber == 4)
                {
                    QuestionDisplay.newQuestion = "Staying apart from other people when you have been exposed to the coronavirus is called?";
                    QuestionDisplay.newA = "A. Physical distancing";
                    QuestionDisplay.newB = "B. Quarantine";
                    QuestionDisplay.newC = "C. Isolation";
                    QuestionDisplay.newD = "D. Social distancing";
                    actualAnswer = "C";
                }

                if (randomNumber == 5)
                {
                    QuestionDisplay.newQuestion = "The best and most accurate way to diagnose Covid-19 is";
                    QuestionDisplay.newA = "A. Identifying symptoms";
                    QuestionDisplay.newB = "B. PCR-based Test";
                    QuestionDisplay.newC = "C. Saliva test";
                    QuestionDisplay.newD = "D. None of the above";
                    actualAnswer = "B";
                }

                // To add completedQuestions
                AnswerQuestion();

                // All questions go above this line
                QuestionDisplay.pleaseUpdate = false;
            }
        }
        
    }

    public void AnswerQuestion()
    {
        questionCount++;
    }

    int GetRandomNumber()
    {
        int randomNumber = Random.Range(minNumber, maxNumber + 1);

        // Check if the number has already been selected
        if (selectedNumbers.Contains(randomNumber))
        {
            // If the number has already been selected, get a new random number
            return GetRandomNumber();
        }
        else
        {
            // If the number has not been selected, add it to the list and return it
            selectedNumbers.Add(randomNumber);
            return randomNumber;
        }
    }
}
