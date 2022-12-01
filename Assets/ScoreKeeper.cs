using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    private static float score;  // everyone has the same score
    private static Text scoreText; // everyone has the same text
    public static bool gameover;

    // Start is called before the first frame update
    internal void Start()
    {
        scoreText = GetComponent<Text>();
        UpdateText();
    }

    public static void AddToScore(float points, int brick_num)
    {
        score += points;
        UpdateText();
        if (brick_num == 0)
        {
            gameover = true;
        }
    }

    private static void UpdateText()
    {
        scoreText.text = String.Format("Score: {0}", score);
    }
}
