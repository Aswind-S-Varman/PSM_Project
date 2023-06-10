using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;

    public static bool pleaseUpdate = false;

    void Start()
    {
        StartCoroutine(PushTextOnScreen());
    }

    void Update()
    {
        if (QuestionGenerate.shouldExecute == true)
        {
            if (pleaseUpdate == false)
            {
                pleaseUpdate = true;
                StartCoroutine(PushTextOnScreen());
            }
        }
/*        else
        {
            StopCoroutine(PushTextOnScreen());
        }*/
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<TextMeshProUGUI>().text = newQuestion;
        answerA.GetComponent<TextMeshProUGUI>().text = newA;
        answerB.GetComponent<TextMeshProUGUI>().text = newB;
        answerC.GetComponent<TextMeshProUGUI>().text = newC;
        answerD.GetComponent<TextMeshProUGUI>().text = newD;
    }
}
