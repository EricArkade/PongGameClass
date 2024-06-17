using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public TMP_Text playerScoreText;
    public TMP_Text playerWinText;
    public int pointsToWin;
    public GameObject GameOverScreen;
    private int playerOneScore = 0;
    private int playerTwoScore = 0;
    public AudioSource scoreSound;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(bool isPlayerOne)
    {
        scoreSound.Play();
        //checar quem pontuou
        //adicionar pontuação na respectiva variável
        //atualizar texto
        if (isPlayerOne)
        {
            playerOneScore = playerOneScore + 1;
            if (playerOneScore >= pointsToWin)
            {
                playerWinText.text = "player 1 wins";
                GameOverScreen.SetActive(true);
                Time.timeScale = 0;
            }
        }
        else
        {
            playerTwoScore = playerTwoScore + 1;
            if (playerTwoScore >= pointsToWin)
            {
                playerWinText.text = "player 2 wins";
                GameOverScreen.SetActive(true);
                Time.timeScale = 0;
            }

        }
        playerScoreText.text = playerOneScore.ToString() + " / " + playerTwoScore.ToString();

        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
