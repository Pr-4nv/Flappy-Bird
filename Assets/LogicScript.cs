using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicScript : MonoBehaviour
{

   public int playerScore;
   [SerializeField]
   TextMeshProUGUI scoreText;

    
   [ContextMenu("Increase Score")] 
   public void addScore()
   {

      playerScore = playerScore + 1;
      scoreText.text = playerScore.ToString();

   }



}
