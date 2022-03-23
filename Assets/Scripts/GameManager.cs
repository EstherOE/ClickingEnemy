﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    static int score =0, highScore;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score : " + score;
        highScore = PlayerPrefs.GetInt("HighScore");
        
    }


    public static void AddScore()
    {

        score++;
    }


    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        highScoreText.text = "HighScore: " + highScore;

        if(score> highScore)
        {

            PlayerPrefs.SetInt("HighScore", score);
        }

    }
}
