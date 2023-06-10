using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate1 : MonoBehaviour
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
                    QuestionDisplay1.newQuestion = "Which of the following is an effective way to build resilience?";
                    QuestionDisplay1.newA = "A. Avoiding all sources of stress";
                    QuestionDisplay1.newB = "B. Seeking perfection in every aspect of life";
                    QuestionDisplay1.newC = "C. Developing a healthy support network";
                    QuestionDisplay1.newD = "D. Dwelling on past mistakes and failures";
                    actualAnswer = "C";
                }

                if (randomNumber == 2)
                {
                    QuestionDisplay1.newQuestion = "Which of the following is NOT an effective communication skill?";
                    QuestionDisplay1.newA = "A. Interrupting others while they speak";
                    QuestionDisplay1.newB = "B. Expressing empathy and understanding";
                    QuestionDisplay1.newC = "C. Actively listening";
                    QuestionDisplay1.newD = "D. Using assertive and respectful language";
                    actualAnswer = "A";
                }

                if (randomNumber == 3)
                {
                    QuestionDisplay1.newQuestion = "Which of the following is a common symptom of anxiety?";
                    QuestionDisplay1.newA = "A. Increased energy levels";
                    QuestionDisplay1.newB = "B. Lack of appetite";
                    QuestionDisplay1.newC = "C. Decreased heart rate";
                    QuestionDisplay1.newD = "D. Restful sleep";
                    actualAnswer = "B";
                }

                if (randomNumber == 4)
                {
                    QuestionDisplay1.newQuestion = "Which of the following is an effective way to improve mental well-being?";
                    QuestionDisplay1.newA = "A. Practicing gratitude and mindfulness";
                    QuestionDisplay1.newB = "B. Engaging in excessive screen time";
                    QuestionDisplay1.newC = "C. Avoiding challenging situations";
                    QuestionDisplay1.newD = "D. Isolating oneself from friends and family";
                    actualAnswer = "A";
                }

                if (randomNumber == 5)
                {
                    QuestionDisplay1.newQuestion = "Which of the following can help reduce stress levels?";
                    QuestionDisplay1.newA = "A. Avoiding sunlight exposure";
                    QuestionDisplay1.newB = "B. Isolating oneself from social interactions";
                    QuestionDisplay1.newC = "C. Consuming excessive amounts of caffeine";
                    QuestionDisplay1.newD = "D. Engaging in regular physical exercise";
                    actualAnswer = "D";
                }

                // To add completedQuestions
                AnswerQuestion();

                // All questions go above this line
                QuestionDisplay1.pleaseUpdate = false;
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
