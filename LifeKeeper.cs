using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class LifeKeeper : MonoBehaviour
{
    private static int lives = 3;  // everyone has the same score
    private static Text livesText; // everyone has the same text
    public static bool gameover;

    // Start is called before the first frame update
    internal void Start()
    {
        livesText = GetComponent<Text>();
        UpdateText();
    }

    public static void SubtractLife()
    {
        lives -= 1;
        if (lives <= 0)
        {
            gameover = true;
        }
        UpdateText();
    }

    private static void UpdateText()
    {
        livesText.text = String.Format("Lives: {0}", lives);
    }
}
