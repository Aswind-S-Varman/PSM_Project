using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public TMP_Text scoreText;
    public static int score;

    void Update()
    {
        scoreText.text = "SCORE: " + score;
    }
}
