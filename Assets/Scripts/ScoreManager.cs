﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
* AUTHOR: Harrison Hough   
* COPYRIGHT: Harrison Hough 2018
* VERSION: 1.0
* SCRIPT: Score Manager Class 
*/


/// <summary>
/// 
/// </summary>
public class ScoreManager : MonoBehaviour {

    private Text scoreText;

    private int score;
    public int Score { get { return score; } }

    /// <summary>
    /// 
    /// </summary>
    private void Awake()
    {
        //MakeInstance();
        scoreText = GameObject.Find("Score Text").GetComponent<Text>();
    }

    /// <summary>
    /// 
    /// </summary>
    public void IncrementScore()
    {
        score++;
        scoreText.text = "" + score;
    }

    public void ResetScore()
    {
        score = 0;
    }

}
