using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScoring : MonoBehaviour
{
    [SerializeField] private Transform ball;
    [SerializeField] private Transform playerPaddle;
    [SerializeField] private Transform AIPaddle;
    [SerializeField] private Text score;
    [SerializeField] private bool isAI;
    private int ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = int.Parse(score.text);
    }

    // Update is called once per frame
    void Update()
    {
        if (isAI)
        {
            AIScore();
        }
        else
        {
            PlayerScore();
        }
        //EndGame();
    }

    private void PlayerScore()
    {
        Vector2 ballPosition = ball.position;
        Vector2 AIPosition = AIPaddle.position;

        if (ballPosition.x > AIPosition.x)
        {
            score.text = ps++.ToString();
            Reset();
        }
    }

    private void AIScore()
    {
        Vector2 ballPosition = ball.position;
        Vector2 playerPosition = playerPaddle.position;

        if (ballPosition.x < playerPosition.x)
        {
            score.text = ps++.ToString();
            Reset();
        }
    }

    private void Reset()
    {
        ball.position = new Vector2 (0, 0);
        playerPaddle.position = new Vector2 (-7.5f, 0);
        AIPaddle.position = new Vector2(7.5f, 0);
    }

    //private void EndGame()
    //{
    //    if (ps > 21)
    //    {
    //        ps = 0;
    //    }
    //}

}
