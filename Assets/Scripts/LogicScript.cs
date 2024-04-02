using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LogicScript : MonoBehaviour
{

    public int playerScore;

    public AudioSource audioSource;
    public AudioClip Pass;

   public GameObject gameOverScreen;

   [SerializeField]
   TextMeshProUGUI scoreText;
   [SerializeField]
    TextMeshProUGUI highScore;
    [SerializeField]
    TextMeshProUGUI ScoreTxtgameOver;


    [ContextMenu("Increase Score")] 

    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("Highscore",0).ToString();
    }
    public void addScore()
   {

      playerScore = playerScore + 1;
      scoreText.text = playerScore.ToString();
      ScoreTxtgameOver.text = playerScore.ToString();

        if(playerScore > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", playerScore);
            highScore.text = playerScore.ToString();
        }

   }

    public void ResteHighscore()
    {
        PlayerPrefs.DeleteKey("Highscore");
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
