using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int playerLivesNum;
    private int CurrentLives;
    public bool gameIsOn;
    public Text livesText;
    public Text scoreText;
    private float highScore;
    public Text endGameText;



    // Start is called before the first frame update
    void Start()
    {
        RestartGame();
        playerLivesNum = 5;
    }

    private void RestartGame()
    {
        CurrentLives = playerLivesNum;
        gameIsOn = true;

        livesText.text = "LIVES: " + CurrentLives;
        highScore = 0;

        endGameText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (gameIsOn)
        {
            highScore += Time.deltaTime * 10;
            scoreText.text = "SCORE: " + System.Math.Round(highScore, 1);
        }
        if (Input.GetKeyDown("r"))
        {
            RestartGame();
        }
    }

    public void UpdatePlayerLives(int amount)
    {
        if (!gameIsOn)
            return;

        CurrentLives += amount;
        Debug.Log("LIVES: " + CurrentLives);
        livesText.text = "LIVES: " + CurrentLives;

        if (CurrentLives <= 0)
        {
            gameIsOn = false;
            Debug.Log("Game Over");
            endGameText.text = "You Have Run Out of Lives!" + "\n Game OVER" + "\n Press R to Restart!";
        }

    }
}
