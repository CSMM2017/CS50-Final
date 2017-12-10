using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    // Watched Tutorials at https://www.youtube.com/channel/UCyBsvsU7uiurMiBZIYXvnyg
    // Sets score to 0 initially, then updates it every time the character collects a paw.

    public static int score;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        score = 0;
    }

    void Update()
    {
        if (score < 0)
            score = 0;
        text.text = "" + score;
    }
    public static void AddPoints (int pointsToAdd)
    {
        score += pointsToAdd;
    }
    public static void Reset()
    {
        score = 0; 
    }
}
