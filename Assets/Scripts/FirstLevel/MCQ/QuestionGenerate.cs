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
                    QuestionDisplay.newQuestion = "What is the recommended duration of time for washing your hands?";
                    QuestionDisplay.newA = "A. 5 seconds";
                    QuestionDisplay.newB = "B. 10 seconds";
                    QuestionDisplay.newC = "C. 20 seconds";
                    QuestionDisplay.newD = "D. 30 seconds";
                    actualAnswer = "C";
                }

                if (randomNumber == 2)
                {
                    QuestionDisplay.newQuestion = "Which of the following is NOT an effective sanitizer against viruses?";
                    QuestionDisplay.newA = "A. Alcohol-based sanitizer";
                    QuestionDisplay.newB = "B. Chlorine-based sanitizer";
                    QuestionDisplay.newC = "C. Soap and Water";
                    QuestionDisplay.newD = "D. Vinegar-based sanitizer";
                    actualAnswer = "C";
                }

                if (randomNumber == 3)
                {
                    QuestionDisplay.newQuestion = "Which of the following is an effective way to cover your cough or sneeze?";
                    QuestionDisplay.newA = "A. Using your hand";
                    QuestionDisplay.newB = "B. Covering nose";
                    QuestionDisplay.newC = "C. Using your shirt";
                    QuestionDisplay.newD = "D. Using your elbow";
                    actualAnswer = "D";
                }

                if (randomNumber == 4)
                {
                    QuestionDisplay.newQuestion = "How often should you sanitize high-touch surfaces such as doorknobs, light switches, and countertops?";
                    QuestionDisplay.newA = "A. Once a day";
                    QuestionDisplay.newB = "B. Twice a week";
                    QuestionDisplay.newC = "C. Once every two weeks";
                    QuestionDisplay.newD = "D. Once a month";
                    actualAnswer = "A";
                }

                if (randomNumber == 5)
                {
                    QuestionDisplay.newQuestion = "Which of the following surfaces is most likely to harbor viruses?";
                    QuestionDisplay.newA = "A. Wood";
                    QuestionDisplay.newB = "B. Plastic";
                    QuestionDisplay.newC = "C. Metal";
                    QuestionDisplay.newD = "D. Glass";
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
