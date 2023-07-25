using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnswerButtons2 : MonoBehaviour
{
    public GameObject answerAbackBlue;      // Blue waiting
    public GameObject answerAbackGreen;     // Green correct
    public GameObject answerAbackRed;       // Red wrong

    public GameObject answerBbackBlue;      // Blue waiting
    public GameObject answerBbackGreen;     // Green correct
    public GameObject answerBbackRed;       // Red wrong

    public GameObject answerCbackBlue;      // Blue waiting
    public GameObject answerCbackGreen;     // Green correct
    public GameObject answerCbackRed;       // Red wrong

    public GameObject answerDbackBlue;      // Blue waiting
    public GameObject answerDbackGreen;     // Green correct
    public GameObject answerDbackRed;       // Red wrong

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public GameObject currentScore;
    public int scoreValue;

    public int bestScore;
    public GameObject bestDisplay;

    // Sounds
    public AudioSource correctFX;
    public AudioSource wrongFX;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<TextMeshProUGUI>().text = "BEST: " + bestScore;
    }


    private void Update()
    {
        currentScore.GetComponent<TextMeshProUGUI>().text = "SCORE: " + scoreValue;

        if (QuestionGenerate2.shouldExecute == false)
        {
            StopCoroutine(NextQuestion());
        }
    }

    public void AnswerA()
    {
        if (QuestionGenerate2.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            scoreValue += 5;
            correctFX.Play();
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            scoreValue -= 1;
            wrongFX.Play();
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenerate2.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            scoreValue += 5;
            correctFX.Play();
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            scoreValue -= 1;
            wrongFX.Play();
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        if (QuestionGenerate2.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            scoreValue += 5;
            correctFX.Play();
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            scoreValue -= 1;
            wrongFX.Play();
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        if (QuestionGenerate2.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            scoreValue += 5;
            correctFX.Play();
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
            scoreValue -= 1;
            wrongFX.Play();
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        if(bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<TextMeshProUGUI>().text = "BEST: " + scoreValue;
        }

        yield return new WaitForSeconds(1);

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);

        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);

        answerAbackBlue.SetActive(false);
        answerBbackBlue.SetActive(false);
        answerCbackBlue.SetActive(false);
        answerDbackBlue.SetActive(false);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        QuestionGenerate2.displayingQuestion = false;
    }
}
