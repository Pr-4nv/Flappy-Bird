using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;

    [ContextMenu("Increase Score")]
    public void addScore()
    
    {
       playerScore = playerScore + 1;
       scoreText.text = playerScore.ToString();

    }

}
