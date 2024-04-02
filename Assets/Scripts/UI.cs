using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
   public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReturnHome()

    {
        SceneManager.LoadScene(0);
    }

    public void OnApplicationQuit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
