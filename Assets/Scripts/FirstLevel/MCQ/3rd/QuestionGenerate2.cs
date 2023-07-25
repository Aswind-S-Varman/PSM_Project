using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate2 : MonoBehaviour
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
                    QuestionDisplay2.newQuestion = "Which of the following is a benefit of vaccination in the post-pandemic situation?";
                    QuestionDisplay2.newA = "A. Increased risk of infection";
                    QuestionDisplay2.newB = "B. Enhanced immune response";
                    QuestionDisplay2.newC = "C. Higher transmission rates";
                    QuestionDisplay2.newD = "D. Weakened immune system";
                    actualAnswer = "B";
                }

                if (randomNumber == 2)
                {
                    QuestionDisplay2.newQuestion = "What is the primary purpose of vaccines in the post-pandemic scenario?";
                    QuestionDisplay2.newA = "A. To promote social distancing";
                    QuestionDisplay2.newB = "B. To boost mental health";
                    QuestionDisplay2.newC = "C. To prevent the spread of diseases";
                    QuestionDisplay2.newD = "D. To encourage travel restrictions";
                    actualAnswer = "C";
                }

                if (randomNumber == 3)
                {
                    QuestionDisplay2.newQuestion = "Which of the following statements about vaccines is correct?";
                    QuestionDisplay2.newA = "A. Vaccines can cause the diseases they protect against";
                    QuestionDisplay2.newB = "B. Vaccines are ineffective in preventing infections";
                    QuestionDisplay2.newC = "C. Vaccines provide long-term immunity without the need for booster shots";
                    QuestionDisplay2.newD = "D. Vaccines work by stimulating the body's immune system to recognize and fight specific pathogens";
                    actualAnswer = "D";
                }

                if (randomNumber == 4)
                {
                    QuestionDisplay2.newQuestion = "How do vaccines help in reducing the impact of infectious diseases in the post-pandemic world?";
                    QuestionDisplay2.newA = "A. By reducing the severity of illness and preventing complications";
                    QuestionDisplay2.newB = "B. By enhancing individual physical strength and stamina";
                    QuestionDisplay2.newC = "C. By completely eradicating all infectious diseases";
                    QuestionDisplay2.newD = "D. By creating artificial immunity that lasts a lifetime";
                    actualAnswer = "A";
                }

                if (randomNumber == 5)
                {
                    QuestionDisplay2.newQuestion = "What is the primary goal of vaccination programs in the post-pandemic situation?";
                    QuestionDisplay2.newA = "A. To generate profits for pharmaceutical companies";
                    QuestionDisplay2.newB = "B. To achieve global dominance in healthcare";
                    QuestionDisplay2.newC = "C. To ensure equitable access to vaccines and prevent disease spread";
                    QuestionDisplay2.newD = "D. To monitor and control the population";
                    actualAnswer = "C";
                }

                // To add completedQuestions
                AnswerQuestion();

                // All questions go above this line
                QuestionDisplay2.pleaseUpdate = false;
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
