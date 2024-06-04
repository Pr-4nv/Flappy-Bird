using NerdStudios.CustomHeader;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionManager : MonoBehaviour
{
    [CustomHeader("CollisionManager", HeaderColor.Blue, 16)]
    [Header("General Variables")]
    public GameObject GameOverScreen;
    public GameObject dynamicTxt;
    public GameObject pipeSpawner;
    public GameObject CoinAndScore;
    public GameObject coinAndScoreTxt;
    public bool isGameOver;

    [Header("VFX")]
    public GameObject vfxPrefab;

    [Header("Animation and Cam")]
    public Animator birdAnimation;
    public CameraShake camShake;

    [Header("Audio Sourse")]
    public AudioSource audioSource;
    public AudioClip treeHitSound;
    public AudioClip groundHitSound;
    public AudioClip gameMusic;
    public AudioClip bgMusic;
    public AudioClip Pass;



    public void Start()
    {
        GameOverScreen.SetActive(false);
        isGameOver = false;
        PlayGameMusic();
    }

    

    //Bird Collition.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (audioSource != null &&  Pass != null && collision.gameObject.CompareTag("Middle"))
        {
            audioSource.PlayOneShot(Pass);

        }
        if (collision.gameObject.CompareTag("Tree") || collision.gameObject.CompareTag("Ground"))
        {
            GameOverScreen.SetActive(true);
            dynamicTxt.SetActive(true);
            CoinAndScore.SetActive(false);
            coinAndScoreTxt.SetActive(false);
            pipeSpawner.SetActive(false);
            isGameOver = true;
            birdAnimation.gameObject.GetComponent<Animator>().enabled = false;

            // Instantiate the VFX 
            InstantiateVFX(collision.GetContact(0).point);

            if (audioSource != null && treeHitSound != null && collision.gameObject.CompareTag("Tree"))
            {
                audioSource.PlayOneShot(treeHitSound);

            }else if (audioSource != null && groundHitSound != null && collision.gameObject.CompareTag("Ground"))
            {
                audioSource.PlayOneShot(groundHitSound);
            }

            camShake.start = true;
          
            
        }
        else
        {
            GameOverScreen.SetActive(false);
        }
    }

    

    
    private void PlayGameMusic()
    {
        if (audioSource != null && gameMusic != null)
        {
            audioSource.clip = gameMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

  /*  private void BackGroundMusic()
    {
        if ( audioSource != null && bgMusic != null)
        {
            audioSource.clip = bgMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }*/

    
    private void InstantiateVFX(Vector2 position)
    {
        GameObject vfxInstance = Instantiate(vfxPrefab, position, Quaternion.identity);
        Destroy(vfxInstance, 3f); 
    }
}
