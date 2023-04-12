using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text playerScoreText;
    public GameObject gameOverScreen;
    public Text gameOverPlayerScoreText;

    [ContextMenu("Increase Score")]
    public void AddScore(int incrementValue) 
    {
        playerScore = playerScore + incrementValue;
        playerScoreText.text =  playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameOverPlayerScoreText.text = "Your Score: " + playerScore.ToString();
    }

}
