﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int scoreAmount;
    private Text scoreText;
    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = " Your Score : " + playerController.playerScore;
    }
}
