using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using NerdStudios.CustomHeader;
using TMPro;

public class LogicScript : MonoBehaviour
{
    [CustomHeader("LogicScript", HeaderColor.Blue, 16)]
    public int playerScore;
    public int totalCoin;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip Pass;

    [Header("Objects")]
    public GameObject gameOverScreen;

    #region

    [Header("Text")]

   [SerializeField] TextMeshProUGUI playerscoreText;
   [SerializeField] TextMeshProUGUI playerhighScore;
   [SerializeField] TextMeshProUGUI ScoreTxtgameOver;
    [SerializeField] TextMeshProUGUI coinScoreTxt;
    [SerializeField] TextMeshProUGUI coinHighScore;
    [SerializeField] TextMeshProUGUI coinTxtGameOver;

    #endregion

    [ContextMenu("Increase Score")] 

    private void Start()
    {
        playerhighScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
        coinHighScore.text = PlayerPrefs.GetInt("TotalCoinCollected").ToString();
    }
    public void addScore()
   {

      playerScore = playerScore + 1;
      playerscoreText.text = playerScore.ToString();
      ScoreTxtgameOver.text = playerScore.ToString();

        if(playerScore > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", playerScore);
            playerhighScore.text = playerScore.ToString();
        }

   }

    public void AddCoin()
    {
        totalCoin += 5;

        coinScoreTxt.text = totalCoin.ToString();
        coinTxtGameOver.text = totalCoin.ToString();

        int storedTotalCoin = PlayerPrefs.GetInt("TotalCoinCollected", 0);

        storedTotalCoin += 5;
        PlayerPrefs.SetInt("TotalCoinCollected", storedTotalCoin);
        coinHighScore.text = storedTotalCoin.ToString();

    }

    public void ResteHighscore()
    {
        PlayerPrefs.DeleteKey("Highscore");
        PlayerPrefs.DeleteKey("TotalCoinCollected");
    }

   public void restartGame() 
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

    public void playPass()
    {
        if (audioSource != null && Pass != null)
        {
            
            audioSource.PlayOneShot(Pass);
        }
    }

   
}
