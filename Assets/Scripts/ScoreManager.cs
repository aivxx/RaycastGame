using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    private int displayScore;
    public TextMeshProUGUI scoreCount;
    public Canvas scoreUI;
    public Canvas gameWin;

    void Start()
    {
        scoreUI.enabled = true;
        score = 0;
        displayScore = 0;
    }

    void Update()
    {
        if (score != displayScore)
        {
            displayScore = score;
            scoreCount.text = displayScore.ToString();
        }

        if (score >=15)
        {
            Time.timeScale = 0f;
            Cursor.visible = true;
            gameWin.enabled = true;
        }
    }
}
