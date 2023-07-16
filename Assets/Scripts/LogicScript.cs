using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{

   public int playerScore;
   public GameObject gameOverScreen;
   [SerializeField]
   TextMeshProUGUI scoreText;

    
   [ContextMenu("Increase Score")] // Increase the score
   public void addScore()
   {

      playerScore = playerScore + 1;
      scoreText.text = playerScore.ToString();

   }

   public void restartGame() // restart the game
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

      
}
