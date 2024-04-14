using UnityEngine;

public class MainMenuTweening : MonoBehaviour
{
    #region Main Menu

    [Header("Main Menu Animations")]

    [SerializeField] GameObject Logo;
    [SerializeField] GameObject PlayButton;
    [SerializeField] GameObject OptionButton;
    [SerializeField] GameObject QuitButton;
    [SerializeField] GameObject BackReactangle;

    #endregion



    void Start()
    {
        
        LeanTween.scale(Logo, new Vector3(3f, 3f, 3f), 2f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.alpha(BackReactangle.GetComponent<RectTransform>(), 1f, .5f).setDelay(1.5f).setOnComplete(MenuOpup);

    }

   

    void MenuOpup()
    {

        LeanTween.scale(PlayButton, new Vector3(1f, 1f, 1f), 2f).setDelay(.1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(OptionButton, new Vector3(1f, 1f, 1f), 2f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(QuitButton, new Vector3(1f, 1f, 1f), 2f).setDelay(.3f).setEase(LeanTweenType.easeOutElastic);
        //LeanTween.scale(CreditButton, new Vector3(1f, 1f, 1f), 2f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);
    }

  
}
