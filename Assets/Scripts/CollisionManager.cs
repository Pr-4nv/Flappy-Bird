using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    
   public GameObject GameOverScreen;
   public GameObject pipeSpawner;
   public bool isGameOver;
   public Animator birdAnimation;
   
   //This helps to make the gameoebject turned of in start of the game.
   public void Start()
   {
       GameOverScreen.SetActive(false);
       isGameOver = false;
   }

    // This line helps to load the scene(game over screen) when the bird hits the object with tag "Tree". 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tree"))
        {
           GameOverScreen.SetActive(true);
           pipeSpawner.SetActive(false);
           isGameOver = true;
           birdAnimation.gameObject.GetComponent<Animator>().enabled = false;
           
        }
        else
        {
            GameOverScreen.SetActive(false);
        }
    }

   
}

